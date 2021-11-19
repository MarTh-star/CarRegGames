using System;
using System.Collections.Generic;
using System.Text;

namespace Platespotting
{
    class SaveTheNumber
    {
        public string savedRegNumber { get; set; }
        public string currentRegNumber { get; set; }

        public SaveTheNumber()
        {

        }

        int currentNumber = 0;

        public void IsNrGood(string regNr)
        {
            string[] splitNr = regNr.Split();
            
            if (int.Parse(splitNr[1]) == currentNumber + 1)
            {
                currentRegNumber = regNr;
                currentNumber += 1;
            }
            else { }
        }
    }

    
    
}
