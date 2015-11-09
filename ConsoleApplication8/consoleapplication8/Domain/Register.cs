using ConsoleApplication8.Resource;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApplication8.Domain
{
    public class Register
    {
        public int id { get; set; }

        public DateTime vencimento { get; set; }

        public int ccontrato { get; set; }

        public string ccredor { get; set; }

        public long ccpfcnpj { get; set; }

        public string cendereco { get; set; }

        public string cbairro { get; set; }

        public string ccidade { get; set; }

        public string cestado { get; set; }

        public int ccep { get; set; }

        public string cinscricaoestadual { get; set; }

        public int codigocredor { get; set; }

        public Int64 contrato { get; set; }

        public Int64 codigotitulo { get; set; }

        public DateTime vencimentoprorrogavel { get; set; }

        public DateTime dataemissao { get; set; }

        public int parcela { get; set; }

        public string plano { get; set; }

        public decimal valortitulo { get; set; }

        public Int64 nossonumero { get; set; }

        public Int64 numdocumento { get; set; }

        public string especiedoc { get; set; }

        public string especmoeda { get; set; }

        public string carteira { get; set; }

        public Int64 cpfcnpj { get; set; }

        public string nomesacado { get; set; }

        public string endereco { get; set; }

        public string enderecocomplemento { get; set; }

        public string bairro { get; set; }

        public int cep { get; set; }

        public string cidade { get; set; }

        public string uf { get; set; }

        public string cedente { get; set; }

        public string banco { get; set; }

        public int agencia{ get; set; }

        public int conta { get; set; }

        public string nomecredor { get; set; }

        public string nomecedente { get; set; }

        public string localpagamento { get; set; }

        public string mensagem1 { get; set; }

        public string mensagem2 { get; set; }

        public string mensagem3 { get; set; }

        public string mensagem4 { get; set; }

        public string mensagem5 { get; set; }

        public string linhadigitavel { get; set; }

        public string codigobarras { get; set; }

        public Int64 codigoretorno { get; set; }

        public decimal valoratual { get; set; }

        public int desconto { get; set; }

        public int codigopessoa { get; set; }

        public string prorrogavel { get; set; }

        public string codecentralizador { get; set; }

        public int numerocentralizador { get; set; }

        public string ctcamarrado { get; set; }

        public string ctcfaixacep { get; set; }

        public DateTime facdatapostagem { get; set; }

        public string kbsfaccontrato { get; set; }

        public string kbsfaccif { get; set; }

        public string mensagem6 { get; set; }

        public string idcarta { get; set; }

        public void parametrosIguais(string texto1, string texto2)
        {
            AssertionConcern.AssertArgumentNotEquals(texto1, texto2, "Mensagens nao devem ser iguais");
        }
        
        // 20131220 formatarString
        public DateTime formatarData(string data)
        {
            int ano = Int32.Parse(data.Substring(0, 4));
            int mes = Int32.Parse(data.Substring(4, 2));
            int dia = Int32.Parse(data.Substring(6, 2));
            
            return new DateTime(ano, mes, dia);

        }

        // 12/12/2012
        public DateTime formatarDataPipi(string data)
        {
            string[] dat = data.Split('/');
            return new DateTime(Int32.Parse(dat[2]), Int32.Parse(dat[1]), Int32.Parse(dat[0]));
            // string[] data = data.split("/"); 
        }

        public decimal formatarValor(string valor)
        {
            return Decimal.Parse( valor.Replace(',' , '.') );
        }

        public string retirarCaracteresEspeciais(string text)
        {
             return Regex.Replace(text, "[^0-9a-zA-Z]+", "");
        }

    }
}
