﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example2
{
    public class FireCommand : ICommand
    {
        public void Execute()
        {
            FireGun();
        }
        private void FireGun()
        {
            Console.WriteLine("Fire Gun");
        }
    }
}
