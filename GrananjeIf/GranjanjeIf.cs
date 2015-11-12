using System;

namespace Vsite.CSharp
{
    class GranjanjeIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                
                if (broj % 2 == 0)
                {
                    Console.WriteLine("broj N je djeljiv s 2");
                }
                else if (broj % 3 == 0)
                    {
                        Console.WriteLine("broj N je djeljiv s 3");
                    }
                else if (broj % 5 == 0)
                        {
                            Console.WriteLine("broj N je djeljiv s 5");
                        }
                else
                        {
                            Console.WriteLine("broj N nije djeljiv niti s jednim brojem");
                        }
                 
                

        
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos");
            }
            Console.ReadKey();
        }
    }
}
