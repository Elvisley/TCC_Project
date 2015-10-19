using ConsoleApplication8.Application;
using ConsoleApplication8.Domain;
using ConsoleApplication8.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.presentation
{
    class Play
    {
        static void Main(string[] args)
        {

            RegisterService _registerService = new RegisterService();

            Register reg = new Register();
         //   reg.texto1 = "Ola mundo";

            _registerService.createRegister(reg);

            Console.ReadKey();


            /*int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Elvis\Documents\ConsoleApplication8\consoleapplication8\archive\modelo.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] dados = line.Split(';');
                System.Console.WriteLine(dados[1]);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine(); */


            //  using (MyDataContext db = new MyDataContext())
            //  {
            //JOB34235_Cartório_Acao_Vivo_Desconto_Mod2

            /*  foreach (Product Product in db.Products)
              {
                  Console.WriteLine(Product.Title);
              }
          }*/

            //Console.ReadKey();
        }
        }
}
