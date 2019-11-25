using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjetoFinal
{
    public class DBComandos
    {
        private static String serverName = "127.0.0.1"; //LocalHost
        private static String port = "5432"; //Porta Usada 
        private static String userName = "postgres"; //Nome do Adm
        private static String password = "2765"; //Senha (Definida)
        private static String databaseName = "corretoria"; //Nome do Database 
        private NpgsqlConnection pgsqlConnection = null; //Criando uma variavel para conexao
        private String connectionString = null; //Criando uma string para controle de conexao

        public DBComandos()
        {
            connectionString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        serverName, port, userName, password, databaseName);
        }

        //Cadastra um CLT
        public void cadastrarCLT(CLT empregado)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("INSERT INTO poo.tb_empregados(nome, cpf, endereco, telefone, pis, cargo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                        empregado.getNome(), empregado.getCpf(), empregado.getEndereco(), empregado.getTelefone(), empregado.getNpis(), empregado.getCargo());
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim do metodo Cadastrar Usuario

        //Cadastrar um CORRETOR
        public void cadastrarCorretor(Corretor empregado)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("INSERT INTO poo.tb_corretores(nome, cpf, endereco, telefone, creci) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        empregado.getNome(), empregado.getCpf(), empregado.getEndereco(), empregado.getTelefone(), empregado.getCreci());
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim do metodo Cadastrar CORRETOR

        //Recupera todos os Corretores
        public DataTable receberNomesCorretores()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT nome FROM poo.tb_corretores";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao dos Nomes dos Corretores

        //Recupera o Id do Corretor
        public DataTable receberIDCorretor(String corretor)
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = String.Format("SELECT id_corretor FROM poo.tb_corretores WHERE nome = '{0}'", corretor);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao do id De um CORRETOR

        //Cadastra uma VENDA feita
        public void cadastrarVenda(Vendas venda)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("INSERT INTO poo.tb_vendas(id_corretor, empreendimento, valor, comissao, mes) VALUES ({0}, '{1}', {2}, {3}, '{4}')",
                        venda.getCorretor(), venda.getEmpreendimento(), venda.getValor(), venda.getComissao(), venda.getMes());
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim do metodo Cadastrar VENDA

        //Cadastra uma ENTRADA/SAIDA
        public void cadastrarEntradaSaida(Double entrada, Double saida, String mes)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("INSERT INTO poo.tb_pagamentos(entrada, saida, mes) VALUES ({0}, {1}, '{2}')",
                       entrada, saida, mes);
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim do metodo Cadastrar ENTRADA/SAIDA

        //Recebe os Empregados CLT
        public DataTable receberEmpregadosCLT()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT * FROM poo.tb_empregados";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao dos CLT

        //Recebe os CORRETORES
        public DataTable receberEmpregadosCorretores()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT * FROM poo.tb_corretores";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao dos CORRETORES

        //Recebe AS VENDAS de um determinado Corretor
        public DataTable receberVendasCorretorEspecifico(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = String.Format("SELECT * FROM poo.tb_vendas WHERE id_corretor = {0}", id);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao dos CORRETORES

        //Recebe TODAS AS VENDAS 
        public DataTable receberVendasTodas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = String.Format("SELECT * FROM poo.tb_vendas");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao das VENDAS

        //Recebe todas as ENTRADAS/SAIDAS
        public DataTable recebeTodasEntradaSaida(String mes)
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = String.Format("SELECT * FROM poo.tb_pagamentos WHERE mes = '{0}'", mes);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da recuperacao de entrada/saida

        //Receber os nomes de todos os CLT
        public DataTable receberNomesCLT()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT nome FROM poo.tb_empregados";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdSelecionarTodos, pgsqlConnection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

            return dt;
        } //Fim da Recuperacao dos Nomes dos CLT

        //Deleta um CLT
        public void demitirClt(String nome)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("DELETE FROM poo.tb_empregados WHERE nome = '{0}'",
                       nome);
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim da Demissao de um CLT

        //Deleta um Corretor
        public void demitirCorretor(String nome)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("DELETE FROM poo.tb_corretores WHERE nome = '{0}'",
                       nome);
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim da Demissao de um Corretor

        //Alterar um clt
        public void alterarCLT(String nome, String atributo, String valor)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("UPDATE poo.tb_empregados SET {0} = '{1}' WHERE nome = '{2}'",
                       atributo, valor ,nome);
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim da Alteracao de um Empregado

        //Alterar um Corretor
        public void alterarCorretor(String nome, String atributo, String valor)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("UPDATE poo.tb_corretores SET {0} = '{1}' WHERE nome = '{2}'",
                       atributo, valor, nome);
                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cmdCadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (pgsqlConnection != null)
                {
                    pgsqlConnection.Close();
                }
            }

        } //Fim da Alteracao de um CORRETOR
    }
}
