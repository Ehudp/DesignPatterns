using System;
using System.Windows.Controls;

namespace Logger
{
    public static class Log
    {
        private static TextBox _txt;
            
        public static void WriteLine(string msg)
        {
            Console.WriteLine(msg);       
            WriteToTxtBlock(msg);
          
        }

        private static void WriteToTxtBlock(string msg)
        {  
            if (_txt==null)return;
            _txt.Text += msg+"\n";
        }

        public static void SetTextBox(TextBox txt)
        {
            _txt = txt;
        }
    }
}   