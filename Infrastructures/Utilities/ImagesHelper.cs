using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Brush = System.Windows.Media.Brush;
using Color = System.Windows.Media.Color;
using PixelFormat = System.Windows.Media.PixelFormat;

namespace Infrastructures.Utilities
{
    public static class ImagesHelper
    {
        /// <summary>
        ///     Restore an image from byte array.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static Image ImageFromByteArray(byte[] buffer)
        {
            if (buffer == null)
                return null;

            using (var ms = new MemoryStream(buffer))
                return Image.FromStream(ms);
        }

        /// <summary>
        ///     Store the byte array representing the image into a file.
        /// </summary>
        /// <param name="filePath">The file path and name for storing the image.</param>
        /// <param name="imageByteArray">The byte array representing the image.</param>
        public static void ImageToFile(string filePath, byte[] imageByteArray)
        {
            using (var fs = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
            using (var bw = new BinaryWriter(fs))
            {
                bw.Write(imageByteArray);

                bw.Close();
                fs.Close();
            }
        }

        /// <summary>
        ///     Convert an image to byte array.
        /// </summary>
        /// <param name="imageToConvert"></param>
        /// <param name="formatOfImage"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image imageToConvert, ImageFormat formatOfImage)
        {
            byte[] imageByteArray;

            using (var ms = new MemoryStream())
            {
                imageToConvert.Save(ms, formatOfImage);
                imageByteArray = ms.ToArray();
            }

            return imageByteArray;
        }

        /// <summary>
        ///     Load an image from a file and convert it to byte array
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static byte[] FileToImage(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var br = new BinaryReader(fs))
            {
                byte[] imageByteArray = br.ReadBytes((int) fs.Length);

                br.Close();
                fs.Close();

                return imageByteArray;
            }
        }

        public static Image ImageFromDrawingBrushDb(byte[] imageByteArray, int size = 40)
        {
            var brush = LoadObjectFromByteArray<DrawingBrush>(imageByteArray);
            Image image = CovnertDrawingBrushToImage(brush);
            return image;
        }

        public static DrawingBrush DrawingBrushFormDb(byte[] imageByteArray)
        {
            var brush = LoadObjectFromByteArray<DrawingBrush>(imageByteArray);
            return brush;
        }

        public static T LoadObjectFromByteArray<T>(Byte[] byteOutput)
        {
            var stream = new MemoryStream(byteOutput);
            var readerLoadObject = (T) XamlReader.Load(stream);
            return readerLoadObject;
        }

        public static Image CovnertDrawingBrushToImage(DrawingBrush drawingBrush, int size = 40)
        {
            if (drawingBrush != null)
            {
                var drawingVisual = new DrawingVisual();
                DrawingContext drawingContext = drawingVisual.RenderOpen();
                drawingContext.DrawImage(new DrawingImage(drawingBrush.Drawing), new Rect(0, 0, size, size));
                drawingContext.Close();

                var bmp = new RenderTargetBitmap(size, size, 96, 96, PixelFormats.Pbgra32);
                bmp.Render(drawingVisual);

                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bmp));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);

                    return Image.FromStream(stream);
                }
            }

            return null;
        }

        public static Image ImageFromXamlFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(fileName);
            }

            Image image;
            using (var stringToLoad = new FileStream(fileName, FileMode.Open))
            {
                var brush = (DrawingBrush) XamlReader.Load(stringToLoad);

                stringToLoad.Close();

                image = CovnertDrawingBrushToImage(brush);
            }

            return image;
        }

        public static Brush ConvertColorToBrush(Color drawingColor)
        {
            Color mediaColor = Color.FromArgb(drawingColor.A, drawingColor.R,
                                              drawingColor.G, drawingColor.B);

            Brush brush = new SolidColorBrush(mediaColor);

            return brush;
        }

        public static DrawingBrush GetWpfActionIcon(string iconKey)
        {            
            return (DrawingBrush)Application.Current.TryFindResource(iconKey);
        }

        public static class ImagingConverter
        {
            private static bool InvokeRequired
            {
                get { return Dispatcher.CurrentDispatcher != Application.Current.Dispatcher; }
            }

            public static BitmapSource CreateBitmapSourceFromImage(Image image)
            {
                if (image == null)
                    throw new ArgumentNullException("image");

                if (Application.Current.Dispatcher == null)
                    return null; // Is it possible?

                try
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        // You need to specify the image format to fill the stream. 
                        // I'm assuming it is PNG
                        image.Save(memoryStream, ImageFormat.Png);
                        memoryStream.Seek(0, SeekOrigin.Begin);

                        // Make sure to create the bitmap in the UI thread
                        if (InvokeRequired)
                            return (BitmapSource) Application.Current.Dispatcher.Invoke(
                                new Func<Stream, BitmapSource>(CreateBitmapSourceFromStream),
                                DispatcherPriority.Normal,
                                memoryStream);

                        return CreateBitmapSourceFromStream(memoryStream);
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public static BitmapSource CreateBitmapSourceFromStream(Stream stream)
            {
                BitmapDecoder bitmapDecoder = BitmapDecoder.Create(
                    stream,
                    BitmapCreateOptions.PreservePixelFormat,
                    BitmapCacheOption.OnLoad);

                // This will disconnect the stream from the image completely...
                var writable = new WriteableBitmap(bitmapDecoder.Frames.Single());
                writable.Freeze();

                return writable;
            }

            public static BitmapSource BitmapSourceFromBrush(Brush drawingBrush, int size = 32, int dpi = 96)
            {
                // RenderTargetBitmap = builds a bitmap rendering of a visual
                PixelFormat pixelFormat = PixelFormats.Pbgra32;
                var rtb = new RenderTargetBitmap(size, size, dpi, dpi, pixelFormat);

                // Drawing visual allows us to compose graphic drawing parts into a visual to render
                var drawingVisual = new DrawingVisual();
                using (DrawingContext context = drawingVisual.RenderOpen())
                {
                    // Declaring drawing a rectangle using the input brush to fill up the visual
                    context.DrawRectangle(drawingBrush, null, new Rect(0, 0, size, size));
                }

                // Actually rendering the bitmap
                rtb.Render(drawingVisual);
                return rtb;
            }

            public static Bitmap BitmapFromSource(BitmapSource bitmapsource)
            {
                Bitmap bitmap;
                using (var outStream = new MemoryStream())
                {
                    BitmapEncoder enc = new BmpBitmapEncoder();
                    enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                    enc.Save(outStream);
                    bitmap = new Bitmap(outStream);
                }
                return bitmap;
            }
        }
    }
}