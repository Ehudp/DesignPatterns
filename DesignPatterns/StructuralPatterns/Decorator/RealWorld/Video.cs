using Logger;

namespace DesignPatterns.StructuralPatterns.Decorator.RealWorld
{
    internal class Video : LibraryItem
    {
        private readonly string _director;
        private readonly int _playTime;
        private readonly string _title;
        // Constructor
        public Video(string director, string title,
            int numCopies, int playTime)
        {
            _director = director;
            _title = title;
            NumCopies = numCopies;
            _playTime = playTime;
        }

        public override void Display()
        {
            Log.WriteLine("\nVideo ----- ");
            Log.WriteLine(" Director: {0}", _director);
            Log.WriteLine(" Title: {0}", _title);
            Log.WriteLine(" # Copies: {0}", NumCopies);
            Log.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}