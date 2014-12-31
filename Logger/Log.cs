using System;
using System.Linq;
using System.Windows.Controls;

namespace Logger
{
    public static class Log
    {
        private static TextBox _txt;
        private static Action<string,bool> _outPutAction;

        public static void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format,args);
            var msg = string.Format(format, args);
            WriteLine(msg);
        }


        public static void Write(string msg)
        {
            Console.Write(msg);

            WriteToOutPut(msg,false);
        }

        public static void WriteLine(string msg)
        {
            Console.WriteLine(msg);       
          
            WriteToOutPut(msg);
        }

        private static void WriteToOutPut(string msg,bool lineDown=true)
        {
            _outPutAction(msg,lineDown);
        }

        private static void WriteToTxtBlock(string msg)
        {  
            //Print To Wpf TextBlock
            if (_txt==null)return;
            _txt.Text += msg+"\n";
        }

        public static void AddSeparator(int lenght=10,string separator="-") 
        {

            string str = string.Empty;
            for (int i = 0; i < lenght; i++)
            {
                str += separator;
            }

            WriteLine(str);
        }

      

        public static void SetTextBox(TextBox txt)
        {
            _txt = txt;
        }

        public static void SetOutPutAction(Action<string,bool> outPutAction)
        {
            _outPutAction = outPutAction;
        }
    }
}   