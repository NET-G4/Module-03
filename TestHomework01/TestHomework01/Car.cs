using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestHomework01
{
    internal class Car
    {
        public string AvtoNumber { get; set; }
        public string Model { get; set; }
        
        public Car(string avtoNumber, string model)
        {
            AvtoNumber=avtoNumber;
            Model=model;
        }
        
    }
}
