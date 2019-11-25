using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjetoFinal_POO
{
    class ComandosBanco
    {
        private static String serverName = "127.0.0.1"; //LocalHost
        private static String port = "5432"; //Porta Usada 
        private static String userName = "postgres"; //Nome do Adm
        private static String password = "2765"; //Senha (Definida)
        private static String databaseName = "POO"; //Nome do Database 
        private NpgsqlConnection pgsqlConnection = null; //Criando uma variavel para conexao
        private String connectionString = null; //Criando uma string para controle de conexao


        public ComandosBanco()
        {
            connectionString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                          serverName, port, userName, password, databaseName);
        }

        public void cadastrar_cliente(Clientes cliente)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();

                    String cadastrar = String.Format("INSERT INTO clientes (nome_empresa,endereço,cnpj,telefone) VALUES ('{0}','{1}','{2}','{3}')",
                        cliente.getNome_empresa(), cliente.getEndereço(), cliente.getCNPJ(), cliente.getTelefone());

                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cadastrar, pgsqlConnection))
                    {
                        pgsqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            { throw ex; }
            finally
            {
                if (pgsqlConnection != null)
                    pgsqlConnection.Close();
            }
        }
        public void cadastrar_produto(Produtos produtos)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();

                    String cadastrar = String.Format("INSERT INTO estoque (nome_produto,codigo_produto,valor,fornecedor,quantidade) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                        produtos.getNome_produto(),produtos.getCodProduto(),produtos.getValor(),produtos.getFornecedor(),produtos.getQuantidade());

                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cadastrar, pgsqlConnection))
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
            { throw ex; }
            finally
            {
                if (pgsqlConnection != null)
                    pgsqlConnection.Close();
            }
        }
        public void cadastrar_fornecedor(Fornecedor fornecedor)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();

                    String cadastrar = String.Format("INSERT INTO fornecedor (nome_fornecedor,telefone,cnpj) VALUES ('{0}','{1}','{2}')",
                        fornecedor.getNomeFornecedor(),fornecedor.getTelefone(),fornecedor.getCNPJ());

                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cadastrar, pgsqlConnection))
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
            { throw ex; }
            finally
            {
                if (pgsqlConnection != null)
                    pgsqlConnection.Close();
            }
        }
        public void cadastrar_venda(Vendas vendas)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();

                    String cadastrar = String.Format("INSERT INTO vendas (valor,cliente) VALUES ('{0}','{1}')",
                        vendas.getValor(),vendas.getCliente());


                    using (NpgsqlCommand pgsqlCommand = new NpgsqlCommand(cadastrar, pgsqlConnection))
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
            { throw ex; }
            finally
            {
                if (pgsqlConnection != null)
                    pgsqlConnection.Close();
            }
        }
        public void deletar_cliente(string nome)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("DELETE FROM clientes WHERE nome_empresa = '{0}'",
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
        }
        public void deletar_produto(string nome)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("DELETE FROM estoque WHERE nome_produto = '{0}'",
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
        }
        public void deletar_fornecedor(string empresa)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("DELETE FROM fornecedor WHERE nome_fornecedor = '{0}'",
                       empresa);
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
        }
        public void alterar_cliente(String nome, String atributo, String valor)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("UPDATE clientes SET {0} = '{1}' WHERE nome = '{2}'",
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

        }
        public void alterar_fornecedor(String nome, String atributo, String valor)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("UPDATE fornecedor SET {0} = '{1}' WHERE nome = '{2}'",
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

        }
        public void alterar_produto(String nome, String atributo, String valor)
        {
            try
            {

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    //Abre a Conexão com o PostgreSQL
                    pgsqlConnection.Open();

                    String cmdCadastrar = String.Format("UPDATE estoque SET {0} = '{1}' WHERE nome = '{2}'",
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

        }
        public DataTable receberNomesProdutos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT nome_produto FROM estoque";

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
        }
        public DataTable receberValorProduto(String nome)
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = String.Format("SELECT * FROM estoque WHERE nome_produto ='{0}'", nome);

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
        }
        public DataTable receberNomesFornecedor()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT nome_fornecedor FROM fornecedor";

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
        }
        public DataTable receberNomesClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT nome_empresa FROM clientes";

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
        }
        public DataTable receberProdutos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT * FROM estoque";

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
        }
        public DataTable receberFornecedor()
        {
            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    String cmdSelecionarTodos = "SELECT * FROM fornecedor";

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
        }








    }



}
