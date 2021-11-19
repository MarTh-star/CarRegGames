using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndCarRegister
{
    class CarRegister
    {
        List<Car> cars { get; set; } = new List<Car>();

        public CarRegister()
        {

        }
        bool resultL = false;
        bool resultD = false;
        bool resultW = false;
        bool resultF = false;
        public bool HasCorrectFormat(string lp)
        {
            try
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (char.IsLetter(lp[i]))
                    {
                        resultL = true;

                    }
                    else
                    {
                        resultL = false;

                    }


                    for (int j = 4; j <= 6; j++)
                    {
                        if (char.IsDigit(lp[j]))
                        {

                            resultD = true;
                        }
                        else
                        {
                            resultD = false;

                        }

                    }

                    if (char.IsWhiteSpace(lp[3]))
                    {
                        resultW = true;
                    }
                    else
                    {
                        resultW = false;

                    }


                }
                if (resultL && resultD && resultW)
                {
                    resultF = true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                resultF = false;
            }
            
            
             

            return resultF;
        }
        
        public bool AddCar(Car car)
        {
            if(HasCorrectFormat(car.LicensePlate))
            {
                cars.Add(car);
            }
            

            return true;
        }
    }
}
