using ConsoleApplication8.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.Domain
{
    public class Register
    {
        public int id { get; set; }

        public DateTime vencimento { get; set; }

        public int ccontrato { get; set; }

        public string ccredor { get; set; }

        public int ccpfcnpj { get; set; }

        public string cendereco { get; set; }

        public string cbairro { get; set; }

        public string ccidade { get; set; }

        public string cestado { get; set; }

        public int ccep { get; set; }

        public string cinscricaoestadual { get; set; }

        public int codigocredor { get; set; }

        public int contrato { get; set; }

        public int codigotitulo { get; set; }

        public DateTime vencimentoprorrogavel { get; set; }

        public DateTime dataemissao { get; set; }

        public int parcela { get; set; }

        public string plano { get; set; }

        public decimal valortitulo { get; set; }

        public int nossonumero { get; set; }

        public int numdocumento { get; set; }

        public string especiedoc { get; set; }

        public string especmoeda { get; set; }

        public string carteira { get; set; }

        public int cpfcnpj { get; set; }

        public string nomesacado { get; set; }

        public string endereco { get; set; }

        public string enderecocomplemento { get; set; }

        public string bairro { get; set; }

        public int cep { get; set; }

        public string cidade { get; set; }

        public string uf { get; set; }

        public string cedente { get; set; }

        public string banco { get; set; }

        public int agendia{ get; set; }

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

        public int codigobarras { get; set; }

        public int codigoretorno { get; set; }

        public decimal valoratual { get; set; }

        public int desconto { get; set; }

        public int codigopessoa { get; set; }

        public string prorrogavel { get; set; }

        public int codecentralizador { get; set; }

        public int numerocentralizador { get; set; }

        public string ctcamarrado { get; set; }

        public string ctcfaixacep { get; set; }

        public DateTime facdatapostagem { get; set; }

        public string kbsfaccontrato { get; set; }

        public int kbsfaccif { get; set; }

        public string mensagem6 { get; set; }

        public int idcarta { get; set; }
        
        public void parametrosIguais(string texto1 ,string texto2)
        {
            AssertionConcern.AssertArgumentNotEquals(texto1, texto2, "Mensagens nao devem ser iguais");
        }

    }
}
