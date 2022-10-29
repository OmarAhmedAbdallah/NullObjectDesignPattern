﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    internal class NullMobile : IMobile
    {
        private static NullMobile _instance;
        private NullMobile()
        { }

        public static NullMobile Instance
        {
            get
            {
                if (_instance == null)
                    return new NullMobile();
                return _instance;
            }
        }

        //do nothing methods  
        public void TurnOff()
        { 
            Console.WriteLine("\nNothing!");

        }

        public void TurnOn()
        {
            Console.WriteLine("\nNothing!");
        }
    }
}
