﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._2
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
         
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Car() { }
        public Car(string make, string model, int year)
        {

        }

        public override string ToString()
        {
            return $
        }


    }
}
