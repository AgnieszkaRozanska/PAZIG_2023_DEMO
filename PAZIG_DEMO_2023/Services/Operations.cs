using PAZIG_DEMO_2023.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAZIG_DEMO_2023.Services
{
    public class Operations : IOperations
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
