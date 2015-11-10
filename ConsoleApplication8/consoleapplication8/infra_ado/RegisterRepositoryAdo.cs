using ConsoleApplication8.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.infra_ado
{
    class RegisterRepositoryAdo
    {

        private DBConexao _conexao;

        public RegisterRepositoryAdo()
        {
            _conexao = new DBConexao();
        }
            
        public bool Add(Register register)
        {

            try
            {
                string save = "INSERT INTO registers ( id,vencimento,ccontrato,ccredor,ccpfcnpj,cendereco,cbairro,ccidade,cestado,ccep,cinscricaoestadual,codigocredor,contrato,";
                save += "codigotitulo,vencimentoprorrogavel,dataemissao,parcela,plano,valortitulo,nossonumero,numdocumento,especiedoc,especmoeda,carteira,cpfcnpj,nomesacado,";
                save += "endereco,enderecocomplemento,bairro,cep,cidade,uf,cedente,banco,agencia,conta,nomecredor,nomecedente,localpagamento,mensagem1,mensagem2,mensagem3,mensagem4,";
                save += "mensagem5,linhadigitavel,codigobarras,codigoretorno,valoratual,desconto,codigopessoa,prorrogavel,codecentralizador,numerocentralizador,ctcamarrado,ctcfaixacep,";
                save += "facdatapostagem,kbsfaccontrato,kbsfaccif,mensagem6,idcarta ) ";

                save += " VALUES ( ";

                save += "NULL , ";
                save += "'" + register.vencimento + "' , ";
                save += "'" + register.ccontrato + "' , ";
                save += "'" + register.ccredor + "' , ";
                save += "'" + register.ccpfcnpj + "' , ";
                save += "'" + register.cendereco + "' , ";
                save += "'" + register.cbairro + "' , ";
                save += "'" + register.ccidade + "' , ";
                save += "'" + register.cestado + "' , ";
                save += "'" + register.ccep + "' , ";
                save += "'" + register.cinscricaoestadual + "' , ";
                save += "'" + register.codigocredor + "' , ";
                save += "'" + register.contrato + "' , ";
                save += "'" + register.codigotitulo + "' , ";
                save += "'" + register.vencimentoprorrogavel + "' , ";
                save += "'" + register.dataemissao + "' , ";
                save += "'" + register.parcela + "' , ";
                save += "'" + register.plano + "' , ";
                save += "'" + register.valortitulo + "' , ";
                save += "'" + register.nossonumero + "' , ";
                save += "'" + register.numdocumento + "' , ";
                save += "'" + register.especiedoc + "' , ";
                save += "'" + register.especmoeda + "' , ";
                save += "'" + register.carteira + "' , ";
                save += "'" + register.cpfcnpj + "' , ";
                save += "'" + register.nomesacado + "' , ";
                save += "'" + register.endereco + "' , ";
                save += "'" + register.enderecocomplemento + "' , ";
                save += "'" + register.bairro + "' , ";
                save += "'" + register.cep + "' , ";
                save += "'" + register.cidade + "' , ";
                save += "'" + register.uf + "' , ";
                save += "'" + register.cedente + "' , ";
                save += "'" + register.banco + "' , ";
                save += "'" + register.agencia + "' , ";
                save += "'" + register.conta + "' , ";
                save += "'" + register.nomecredor + "' , ";
                save += "'" + register.nomecedente + "' , ";
                save += "'" + register.localpagamento + "' , ";
                save += "'" + register.mensagem1 + "' , ";
                save += "'" + register.mensagem2 + "' , ";
                save += "'" + register.mensagem3 + "' , ";
                save += "'" + register.mensagem4 + "' , ";
                save += "'" + register.mensagem5 + "' , ";
                save += "'" + register.linhadigitavel + "' , ";
                save += "'" + register.codigobarras + "' , ";
                save += "'" + register.codigoretorno + "' , ";
                save += "'" + register.valoratual + "' , ";
                save += "'" + register.desconto + "' , ";
                save += "'" + register.codigopessoa + "' , ";
                save += "'" + register.prorrogavel + "' , ";
                save += "'" + register.codecentralizador + "' , ";
                save += "'" + register.numerocentralizador + "' , ";
                save += "'" + register.ctcamarrado + "' , ";
                save += "'" + register.ctcfaixacep + "' , ";
                save += "'" + register.facdatapostagem + "' , ";
                save += "'" + register.kbsfaccontrato + "' , ";
                save += "'" + register.kbsfaccif + "' , ";
                save += "'" + register.mensagem6 + "' , ";
                save += "'" + register.idcarta + "' ";

                save += " ) ";

                _conexao.Insert(save);

                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir. " + e.Message);
            }
           
        }


        public IEnumerable<Register> buscar()
        {

            string query = " SELECT * FROM registers ";

            using (MySqlDataReader reader = _conexao.Select(query))
            {

                while (reader.Read())
                {
                    
                    Console.WriteLine("{0}", reader["ccontrato"]);

                    /*reader["vencimento"];
                    reader["ccontrato"];
                    reader["ccredor"];
                    reader["ccpfcnpj"];
                    reader["cendereco"];
                    reader["cbairro"];
                    reader["ccidade"];
                    reader["cestado"];
                    reader["ccep"];
                    reader["cinscricaoestadual"];
                    reader["codigocredor"];
                    reader["contrato"];
                    reader["codigotitulo"];
                    reader["vencimentoprorrogavel"];
                    reader["dataemissao"];
                    reader["parcela"];
                    reader["plano"];
                    reader["valortitulo"];
                    reader["nossonumero"];
                    reader["numdocumento"];
                    reader["especiedoc"];
                    reader["especmoeda"];
                    reader["carteira"];
                    reader["cpfcnpj"];
                    reader["nomesacado"];
                    reader["endereco"];
                    reader["enderecocomplemento"];
                    reader["bairro"];
                    reader["cep"];
                    reader["cidade"];
                    reader["uf"];
                    reader["cedente"];
                    reader["banco"];
                    reader["agencia"];
                    reader["conta"];
                    reader["nomecredor"];
                    reader["nomecedente"];
                    reader["localpagamento"];
                    reader["mensagem1"];
                    reader["mensagem2"];
                    reader["mensagem3"];
                    reader["mensagem4"];
                    reader["mensagem5"];
                    reader["linhadigitavel"];
                    reader["codigobarras"];
                    reader["codigoretorno"];
                    reader["valoratual"];
                    reader["desconto"];
                    reader["codigopessoa"];
                    reader["prorrogavel"];
                    reader["codecentralizador"];
                    reader["numerocentralizador"];
                    reader["ctcamarrado"];
                    reader["ctcfaixacep"];
                    reader["facdatapostagem"];
                    reader["kbsfaccontrato"];
                    reader["kbsfaccif"];
                    reader["mensagem6"];
                    reader["idcarta"];*/
                }


                reader.Close();

                return null;
            }

              
        }
        

    }
}
