﻿using ConsoleApplication8.Application;
using ConsoleApplication8.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.presentation
{
    class PlayAdo
    {


        public PlayAdo()
        {
            
            RegisterServiceAdo _registerService = new RegisterServiceAdo();

            /*
            1.	Tempo gasto na implementação para leitura nos dados de Excel
            2.	Tempo gasto para implementar a inserção no banco de dados usando as duas ferramentas
            3.	Tempo que cada uma das ferramentas precisa para cadastrar todos os registros no banco
            4.	Tempo que cada uma das ferramentas gasta pra trazer os dados do arquivo importado
            5.	Tempo que cada ferramenta gasta para retornar todos os registros salvos no banco
            6.	Quanto cada ferramenta utiliza de Memória RAM e Processador da maquina
            
            */

            System.Console.WriteLine("ADO PURO");

            System.Console.WriteLine("Iniciando a importacao da planilha");


            int counter = 0;
            string line;

            Stopwatch sw = new Stopwatch();

            sw.Start();
            

             // Read the file and display it line by line.
             System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Elvisley\Documents\GitHub\TCC_Project\ConsoleApplication8\consoleapplication8\archive\modelo.txt");
             while ((line = file.ReadLine()) != null)
             {

                 if (counter > 0)
                 {

                     string[] dados = line.Split(';');
                     System.Console.WriteLine(dados[0]);
                     Register reg = new Register();
                     reg.vencimento = dados[0].ToString();
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
                     reg.vencimentoprorrogavel = dados[13].ToString();
                     reg.dataemissao = dados[14].ToString();
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
                     reg.facdatapostagem = dados[54].ToString();
                     reg.kbsfaccontrato = dados[55];
                     reg.kbsfaccif = dados[56];
                     reg.mensagem6 = dados[57];
                     reg.idcarta = dados[58];

                     _registerService.createRegisterAdo(reg);
                    
                 }

                 counter++;
             }

            sw.Stop();

            System.Console.WriteLine("importacao realizada com sucesso");

            TimeSpan tempo = sw.Elapsed;

            System.Console.WriteLine("Foram importadas {0} linhas.", counter);

            System.Console.WriteLine("Tempo gasto para importacao  {0}.", tempo.ToString());

            file.Close();

            System.Console.WriteLine("Buscando todos os dados");

            sw.Start();

            IEnumerable<Register> registros = _registerService.list();

            sw.Stop();
            TimeSpan tempoconsulta = sw.Elapsed;

            Console.WriteLine("Retornou {0} registros", registros.Count());

            System.Console.WriteLine("Tempo gasto para buscar  {0}.", tempoconsulta.ToString());

            // Suspend the screen.
            System.Console.ReadLine();

            //JOB34235_Cartório_Acao_Vivo_Desconto_Mod2
        }
    }
}
