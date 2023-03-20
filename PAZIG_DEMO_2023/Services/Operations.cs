using PAZIG_DEMO_2023.Services.Interfaces;

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
