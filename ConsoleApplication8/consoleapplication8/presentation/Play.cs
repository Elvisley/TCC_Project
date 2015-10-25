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

           /* RegisterService _registerService = new RegisterService();

            Register reg = new Register();
         //   reg.texto1 = "Ola mundo";

            _registerService.createRegister(reg);

            Console.ReadKey()*/


            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Elvis\Documents\ConsoleApplication8\consoleapplication8\archive\modelo.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    string[] dados = line.Split(';');
                    System.Console.WriteLine(dados[0]);

                    var datavencmento = dados[0];
                    int ano = Int32.Parse(datavencmento.Substring(0, 4));
                    int mes = Int32.Parse(datavencmento.Substring(4, 2));
                    int dia = Int32.Parse(datavencmento.Substring(6, 2));

                    DateTime vencimento = new DateTime(ano, mes, dia);

                    Register reg = new Register();
                    reg.vencimento = vencimento;
                    /*reg.ccontrato = dados[1];
                    reg.ccredor = dados[2];
                    reg.ccpfcnpj = dados[3];
                    reg.cendereco = dados[4];
                    reg.cbairro = dados[5];
                    reg.ccidade = dados[6];
                    reg.cestado = dados[7];
                    reg.ccep = dados[8];
                    reg.cinscricaoestadual = dados[9];
                    reg.codigocredor = dados[10];
                    reg.contrato = dados[11];
                    reg.codigotitulo = dados[12];
                    reg.vencimentoprorrogavel = dados[13];
                    reg.dataemissao = dados[14];
                    reg.parcela = dados[15];
                    reg.plano = dados[16];
                    reg.valortitulo = dados[17];
                    reg.nossonumero = dados[18];
                    reg.numdocumento = dados[19];
                    reg.especiedoc = dados[20];
                    reg.especmoeda = dados[21];
                    reg.carteira = dados[22];
                    reg.cpfcnpj = dados[23];
                    reg.nomesacado = dados[24];
                    reg.endereco = dados[25];
                    reg.enderecocomplemento = dados[26];
                    reg.bairro = dados[27];
                    reg.cep = dados[28];
                    reg.cidade = dados[29];
                    reg.uf = dados[30];
                    reg.cedente = dados[31];
                    reg.banco = dados[32];
                    reg.agencia = dados[33];
                    reg.conta = dados[34];
                    reg.nomecredor = dados[35];
                    reg.nomecedente = dados[36];
                    reg.localpagamento = dados[37];
                    reg.mensagem1 = dados[38];
                    reg.mensagem2 = dados[39];
                    reg.mensagem3 = dados[40];
                    reg.mensagem4 = dados[41];
                    reg.mensagem5 = dados[42];
                    reg.linhadigitavel = dados[43];
                    reg.codigobarras = dados[44];
                    reg.codigoretorno = dados[45];
                    reg.valoratual = dados[46];
                    reg.desconto = dados[47];
                    reg.codigopessoa = dados[48];
                    reg.prorrogavel = dados[49];
                    reg.codecentralizador = dados[50];
                    reg.numerocentralizador = dados[51];
                    reg.ctcamarrado = dados[52];
                    reg.ctcfaixacep = dados[53];
                    reg.facdatapostagem = dados[54];
                    reg.kbsfaccontrato = dados[55];
                    reg.kbsfaccif = dados[56];
                    reg.mensagem6 = dados[57];
                    reg.idcarta = dados[58]; */

                }

                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine(); 


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
