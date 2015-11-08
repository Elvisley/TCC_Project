using ConsoleApplication8.Application;
using ConsoleApplication8.Domain;
using ConsoleApplication8.infra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.presentation
{
    class Play
    {
        static void Main(string[] args)
        {

            RegisterService _registerService = new RegisterService();
           
            int counter = 0;
            string line;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Elvis\Documents\ConsoleApplication8\consoleapplication8\archive\modelo.txt");
            while ((line = file.ReadLine()) != null)
            {
                
                if (counter > 0)
                {
                    
                    string[] dados = line.Split(';');
                    System.Console.WriteLine(dados[0]);
                    Register reg = new Register();
                    reg.vencimento = reg.formatarData(dados[0]);
                    reg.ccontrato = int.Parse(dados[1]);
                    reg.ccredor = dados[2];
                    reg.ccpfcnpj = Int64.Parse(reg.retirarCaracteresEspeciais(dados[3]));
                    reg.cendereco = dados[4];
                    reg.cbairro = dados[5];
                    reg.ccidade = dados[6];
                    reg.cestado = dados[7];
                    reg.ccep = Int32.Parse(dados[8]);
                    reg.cinscricaoestadual = dados[9];
                    reg.codigocredor = Int32.Parse(dados[10]);
                    reg.contrato = Int64.Parse(dados[11]);
                    reg.codigotitulo = Int64.Parse(dados[12]);
                    reg.vencimentoprorrogavel = reg.formatarData(dados[13]);
                    reg.dataemissao = reg.formatarDataPipi(dados[14]);
                    reg.parcela = Int32.Parse(dados[15]);
                    reg.plano = dados[16];
                    reg.valortitulo = reg.formatarValor(dados[17]);
                    reg.nossonumero = ( dados[18] == "" ) ? 0 : Int64.Parse(dados[18]);
                    reg.numdocumento = Int64.Parse(dados[19]);
                    reg.especiedoc = dados[20];
                    reg.especmoeda = dados[21];
                    reg.carteira = dados[22];
                    reg.cpfcnpj = Int64.Parse(dados[23]);
                    reg.nomesacado = dados[24];
                    reg.endereco = dados[25];
                    reg.enderecocomplemento = dados[26];
                    reg.bairro = dados[27];
                    reg.cep = Int32.Parse(dados[28]);
                    reg.cidade = dados[29];
                    reg.uf = dados[30];
                    reg.cedente = dados[31];
                    reg.banco = dados[32];
                    reg.agencia = Int32.Parse(dados[33]);
                    reg.conta = Int32.Parse(dados[34]);
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
                    reg.codigoretorno = Int64.Parse(dados[45]);
                    reg.valoratual = reg.formatarValor(dados[46]);
                    reg.desconto = Int32.Parse(dados[47].Replace('%',' '));
                    reg.codigopessoa = Int32.Parse(dados[48]);
                    reg.prorrogavel = dados[49];
                    reg.codecentralizador = dados[50];
                    reg.numerocentralizador = Int32.Parse(dados[51]);
                    reg.ctcamarrado = dados[52];
                    reg.ctcfaixacep = dados[53];
                    reg.facdatapostagem = reg.formatarDataPipi(dados[54]);
                    reg.kbsfaccontrato = dados[55];
                    reg.kbsfaccif = dados[56];
                    reg.mensagem6 = dados[57];
                    reg.idcarta = dados[58];

                    _registerService.createRegister(reg);

                   // Console.ReadKey();

                }

                counter++;
            }

            sw.Stop();

            TimeSpan tempo = sw.Elapsed;

            System.Console.WriteLine("Time {0}.", tempo.ToString());

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine(); 
            
            //JOB34235_Cartório_Acao_Vivo_Desconto_Mod2
            
        }
        }
}
