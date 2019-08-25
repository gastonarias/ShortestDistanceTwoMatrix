using System;

namespace ConsoleAppBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resultado 6
            string[,] arrayTwoDimensions = new string[4, 4] { {"0", "*", "0", "s"},
                                                              {"*", "0", "*", "*"},
                                                              {"0", "0", "*", "*"},
                                                              {"d", "*", "*", "*"} };

            //Resultado -1
            //string[,] arrayTwoDimensions = new string[4, 4] { {"0", "*", "0", "s"},
            //                                                  {"*", "0", "*", "*"},
            //                                                  {"0", "*", "*", "*"},
            //                                                  {"d", "0", "0", "0"} };

            var pro = new Process();
            var ret = pro.MinDistance(arrayTwoDimensions);

            Console.Write(ret);

            Console.ReadKey();
        }
    }
}
