using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RandomGenValue
{

    public static class Program
    {
        /// <summary>
        public static int count = 1;
        public static int[] GenerateValues(Random rand, int Count)
        {
            int[] values = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                values[i] = rand.Next();
            }

            return values;
        }

        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
        
    }
}