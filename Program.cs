using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace CSC_205_CH9_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("called before MyMethod");
                MyMethod();
                Console.WriteLine("called after MyMethod");

                //StreamReader inFile = new StreamReader("input.txt");
                //Console.WriteLine(inFile.ReadLine());

                //inFile.Close();

            }

            catch (FileNotFoundException e)
            {
                // recovery code
                Console.WriteLine("File not found" + e.Message);
                throw; //re-throw
            }

            catch (Exception e)
            {
                // recovery code
                Console.WriteLine("catch them all" + e.Message);

            }

            finally
            {
                Console.WriteLine("I am always gettingn called");
            }

            Console.WriteLine("The End");
            
        }

        static void MyMethod()
        {
            throw new DivideByZeroException();
            //throw new DivideByZeroException();
            throw new FileNotFoundException();

        }

        static int FutureMethod()
        {
            throw new NotImplementedException();

        }
    }

}
