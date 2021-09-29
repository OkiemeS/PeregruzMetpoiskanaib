using System;

namespace PeregruzMetpoiskanaib
{
    class Program
    {
        static void Main(string[] args)
        {
            
            metodPoiska metodpoiska = new metodPoiska();
           int alfa = metodpoiska.MetodBogooW(15, 13, 55, 33, 67, 77, 444, 999);
            Console.WriteLine(alfa);
            int beta = metodpoiska.MetodPoiska(13, 19, 122);
            Console.WriteLine(beta);
            string sigma = metodpoiska.MetodBogooS("dasda", "fsdffwe", "fsdfegwgg", "ds");
            Console.WriteLine(sigma);
        }
    }
}
