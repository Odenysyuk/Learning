using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int first;
                string line = Console.ReadLine();
                first = Int32.Parse(line);

                Console.WriteLine("1 / first = {0}", (1 / first));
            }
            catch(FormatException)
            {
                Console.WriteLine("Incorrect data. String don't parse to Int32");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divided by 0.");
            }
            finally
            {

                Console.WriteLine("Finally");
            }

            /////////////////////
            //checked
            try
            {
                Int32 i  = 9999;
                
                checked
                {
                    i = i * 999999;
                    Console.WriteLine(i);
                }

            }
            catch(OverflowException)
            {
                Console.WriteLine("OverflowException.");
            }

            catch (Exception)
            {
                Console.WriteLine("Exception.");
            }


        }
    }
}
