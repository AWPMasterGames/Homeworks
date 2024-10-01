using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_30._09
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Caculator calc = new Caculator();
                calc.Calc();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на 0 незя");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправельный формат запроса");
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

        }
    }
}
