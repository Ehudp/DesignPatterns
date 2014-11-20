using System;
using System.Collections.Generic;

namespace DesignPatterns.Utilities
{
    public class AppManager
    {
        private static readonly Dictionary<string, Action> Actions = new Dictionary<string, Action>();

        public static void Run()
        {
            FillActions();

            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("Press apropriate LETTER key to run demo or ESC to quit:");
                PrintMethodNames();
                key = Console.ReadKey();
                string methodKey = char.ToUpper(key.KeyChar).ToString();
                InvokeMethod(methodKey);
            } while (key.Key != ConsoleKey.Escape);
        }


        private static void FillActions()
        {
            //Creational Patterns
            Actions.Add("A", MethodService.AbstractFactoryStructural);
            Actions.Add("B", MethodService.AbstractFactoryRealWorld);
        }

        private static void PrintMethodNames()
        {
            foreach (var action in Actions)
            {
                Console.WriteLine("{0}: {1}", action.Key, action.Value.Method.Name);
            }
        }

        private static void InvokeMethod(string key)
        {
            if (!Actions.ContainsKey(key)) return;

            Action action = Actions[key];
            Console.Clear();
            Console.WriteLine("-----------{0}-----------", action.Method.Name);

            action.Invoke();

            Console.WriteLine();
            Console.WriteLine("Press any key to RETURN ...");
            Console.ReadKey();
        }
    }
}