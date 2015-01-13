﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simpleDB
{
    class SimpleDB
    {
        static void Main(string[] args)
        {
            CommandController controller = new CommandController();
            
            Console.WriteLine("Program is live. Enter commands:");
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine(controller.ExecuteCommandString(input));
            }
        }
    }
}
