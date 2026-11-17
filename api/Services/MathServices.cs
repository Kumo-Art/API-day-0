
namespace api.Services
{
    public class MathServices : IMathServices
    {
         public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
    }
}