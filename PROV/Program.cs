using System;

namespace PROV
{
    class Program
    {
        static void Main(string[] args)
        {
         
            books q = new books();

            books b = new books();


            string book = b.nameBook;
            
            int quan = q.Quantity;
            
            System.Console.WriteLine("du har boken " + book);

            System.Console.WriteLine("du har " + quan + " stycken av den boken");

            Console.ReadLine();
        }
    }
}
