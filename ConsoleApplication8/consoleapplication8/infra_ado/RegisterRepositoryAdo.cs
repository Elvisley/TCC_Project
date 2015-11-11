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

            List<Register> registros = new List<Register>();

            using (MySqlDataReader reader = _conexao.Select(query))
            {

                while (reader.Read())
                {
                    
                   // Console.WriteLine("{0}", reader["ccontrato"]);

                    Register reg = new Register();
                   // reg.vencimento = new DateTime(long.Parse(reader["vencimento"].ToString()));
                    reg.ccontrato = Int32.Parse(reader["ccontrato"].ToString());
                    reg.ccredor = reader["ccredor"].ToString();
                    reg.ccpfcnpj = long.Parse(reader["ccpfcnpj"].ToString());
                    reg.cendereco = reader["cendereco"].ToString();
                    reg.cbairro = reader["cbairro"].ToString();
                    reg.ccidade = reader["ccidade"].ToString();
                    reg.cestado = reader["cestado"].ToString();
                    reg.ccep = Int32.Parse(reader["ccep"].ToString());
                    reg.cinscricaoestadual = reader["cinscricaoestadual"].ToString();
                    reg.codigocredor = Int32.Parse(reader["codigocredor"].ToString());
                    reg.contrato = long.Parse(reader["contrato"].ToString());
                    reg.codigotitulo = long.Parse(reader["codigotitulo"].ToString());
                    //reg.vencimentoprorrogavel = reader["vencimentoprorrogavel"].ToString();
                    //reg.dataemissao = reader["dataemissao"].ToString();
                    reg.parcela = Int32.Parse(reader["parcela"].ToString());
                    reg.plano = reader["plano"].ToString();
                   // reg.valortitulo = reader["valortitulo"].ToString();
                    reg.nossonumero = long.Parse(reader["nossonumero"].ToString());
                    reg.numdocumento = long.Parse(reader["numdocumento"].ToString());
                    reg.especiedoc = reader["especiedoc"].ToString();
                    reg.especmoeda = reader["especmoeda"].ToString();
                    reg.carteira = reader["carteira"].ToString();
                    reg.cpfcnpj = long.Parse(reader["cpfcnpj"].ToString());
                    reg.nomesacado = reader["nomesacado"].ToString();
                    reg.endereco = reader["endereco"].ToString();
                    reg.enderecocomplemento = reader["enderecocomplemento"].ToString();
                    reg.bairro = reader["bairro"].ToString();
                    reg.cep = Int32.Parse(reader["cep"].ToString());
                    reg.cidade = reader["cidade"].ToString();
                    reg.uf = reader["uf"].ToString();
                    reg.cedente = reader["cedente"].ToString();
                    reg.banco = reader["banco"].ToString();
                    reg.agencia = Int32.Parse(reader["agencia"].ToString());
                    reg.conta = Int32.Parse(reader["conta"].ToString());
                    reg.nomecredor = reader["nomecredor"].ToString();
                    reg.nomecedente = reader["nomecedente"].ToString();
                    reg.localpagamento = reader["localpagamento"].ToString();
                    reg.mensagem1 = reader["mensagem1"].ToString();
                    reg.mensagem2 = reader["mensagem2"].ToString();
                    reg.mensagem3 = reader["mensagem3"].ToString();
                    reg.mensagem4 = reader["mensagem4"].ToString();
                    reg.mensagem5 = reader["mensagem5"].ToString();
                    reg.linhadigitavel = reader["linhadigitavel"].ToString();
                    reg.codigobarras = reader["codigobarras"].ToString();
                    reg.codigoretorno = long.Parse(reader["codigoretorno"].ToString());
                   // reg.valoratual = reader["valoratual"].ToString();
                    reg.desconto = Int32.Parse(reader["desconto"].ToString());
                    reg.codigopessoa = Int32.Parse(reader["codigopessoa"].ToString());
                    reg.prorrogavel = reader["prorrogavel"].ToString();
                    reg.codecentralizador = reader["codecentralizador"].ToString();
                    reg.numerocentralizador = Int32.Parse(reader["numerocentralizador"].ToString());
                    reg.ctcamarrado = reader["ctcamarrado"].ToString();
                    reg.ctcfaixacep = reader["ctcfaixacep"].ToString();
                   // reg.facdatapostagem = reader["facdatapostagem"].ToString();
                    reg.kbsfaccontrato = reader["kbsfaccontrato"].ToString();
                    reg.kbsfaccif = reader["kbsfaccif"].ToString();
                    reg.mensagem6 = reader["mensagem6"].ToString();
                    reg.idcarta = reader["idcarta"].ToString();


                    registros.Add(reg);
                }


                reader.Close();

                return registros;
            }

              
        }
        

    }
}
