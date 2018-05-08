using CommonLibrary;
using System;

namespace SampleEntityFramworkWithNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = NinjectDependancyGenerator.GetControllerService();
            foreach (var str in controller.GetFilteredList())
            {                
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
