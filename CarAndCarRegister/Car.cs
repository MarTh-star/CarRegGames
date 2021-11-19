using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndCarRegister
{
    class Car
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, string licensePlate, string color )
        {
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
            Color = color;
        }
    }
}
