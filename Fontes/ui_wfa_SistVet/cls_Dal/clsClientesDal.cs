using cls_modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cls_Dal
{
    public class clsClientesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandosSql;
        private DataTable _tabela;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private int ObterProximoId()
        {
            int codigo = 0;
            try
            {
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText =
                    "SELECT ISNULL(MAX(cliid), 0) + 1 AS codigo FROM tblClientes";
                codigo = Convert.ToInt32(_comandosSql.ExecuteScalar());
                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }

        public void Inserir(clsClientes parCliente)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();
            int codigoCliente = ObterProximoId();

            // Inserir o cliente na tabela tblClientes
            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "INSERT INTO tblClientes (cliid, clinome, clicpf, cliemail, clidatacadastro) " +
                                       "VALUES (@cliid, @clinome, @clicpf, @cliemail, @clidatacadastro)";
            _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = codigoCliente;
            _comandosSql.Parameters.Add("@clinome", SqlDbType.VarChar).Value = parCliente.Nome;
            _comandosSql.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = parCliente.CPF;
            _comandosSql.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = parCliente.Email;
            _comandosSql.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = parCliente.DataCadastro;
            _comandosSql.ExecuteNonQuery();

            // Inserir as associações de animais na tabela tblAnimaisClientes
            foreach (clsAnimais animal in parCliente.AnimaisAssociados)
            {
                _comandosSql.CommandText = "INSERT INTO tblAnimaisClientes (cliid, aniid) " +
                                           "VALUES (@cliid, @aniid)";
                _comandosSql.Parameters.Clear(); // Limpar os parâmetros anteriores
                _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = codigoCliente;
                _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = animal.Id;
                _comandosSql.ExecuteNonQuery();
            }

            Conexao.FecharConexao();
        }
        public void Atualizar(clsClientes parCliente)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            // Atualizar informações do cliente na tabela tblClientes
            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "UPDATE tblClientes " +
                                       "SET clinome = @clinome, clicpf = @clicpf, " +
                                       "cliemail = @cliemail, clidatacadastro = @clidatacadastro " +
                                       "WHERE cliid = @cliid";
            _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parCliente.Id;
            _comandosSql.Parameters.Add("@clinome", SqlDbType.VarChar).Value = parCliente.Nome;
            _comandosSql.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = parCliente.CPF;
            _comandosSql.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = parCliente.Email;
            _comandosSql.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = parCliente.DataCadastro;

            _comandosSql.ExecuteNonQuery();

            // Excluir associações existentes do cliente na tabela tblAnimaisClientes
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = _conexao;
            deleteCommand.CommandText = "DELETE FROM tblAnimaisClientes WHERE cliid = @cliid";
            deleteCommand.Parameters.Add("@cliid", SqlDbType.Int).Value = parCliente.Id;
            deleteCommand.ExecuteNonQuery();

            // Inserir as novas associações de animais na tabela tblAnimaisClientes
            foreach (clsAnimais animal in parCliente.AnimaisAssociados)
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = _conexao;
                insertCommand.CommandText = "INSERT INTO tblAnimaisClientes (cliid, aniid) " +
                                           "VALUES (@cliid, @aniid)";
                insertCommand.Parameters.Add("@cliid", SqlDbType.Int).Value = parCliente.Id;
                insertCommand.Parameters.Add("@aniid", SqlDbType.Int).Value = animal.Id;
                insertCommand.ExecuteNonQuery();
            }

            Conexao.FecharConexao();
        }
        public void Excluir(clsClientes parCliente)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "DELETE tblClientes " +
                                       "WHERE cliid = @cliid";
            _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parCliente.Id;
            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public DataTable ListarTodos()
        {
            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "select cliid, clinome, clicpf, cliemail, clidatacadastro, clianiid " +
                                           " from tblClientes " +
                                           " order by cliid ";
                _tabela = new DataTable();
                _adapter = new SqlDataAdapter(_comandosSql);
                _adapter.Fill(_tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return _tabela;
        }
        public List<clsClientes> listarTodosArray()
        {
            List<clsClientes> clientes = new List<clsClientes>();

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "SELECT C.cliid, C.clinome, C.clicpf, C.cliemail, C.clidatacadastro, AC.aniid " +
                                            "FROM tblClientes C " +
                                            "LEFT JOIN tblAnimaisClientes AC ON C.cliid = AC.cliid " +
                                            "ORDER BY C.cliid, AC.aniid";

                _reader = _comandosSql.ExecuteReader();

                int currentClientId = -1;
                clsClientes currentCliente = null;

                while (_reader.Read())
                {
                    int clientId = Convert.ToInt32(_reader["cliid"]);

                    if (clientId != currentClientId)
                    {
                        currentCliente = new clsClientes
                        {
                            Id = clientId,
                            Nome = _reader["clinome"] == DBNull.Value ? string.Empty : _reader["clinome"].ToString(),
                            CPF = _reader["clicpf"] == DBNull.Value ? 0 : Convert.ToDecimal(_reader["clicpf"]),
                            Email = _reader["cliemail"] == DBNull.Value ? string.Empty : _reader["cliemail"].ToString(),
                            DataCadastro = _reader["clidatacadastro"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(_reader["clidatacadastro"]),
                            AnimaisAssociados = new List<clsAnimais>()
                        };

                        clientes.Add(currentCliente);
                        currentClientId = clientId;
                    }

                    if (_reader["aniid"] != DBNull.Value)
                    {
                        int animalId = Convert.ToInt32(_reader["aniid"]);

                        clsAnimais animal = new clsAnimais
                        {
                            Id = animalId
                        };

                        currentCliente.AnimaisAssociados.Add(animal);
                    }
                }

                _reader.Close();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
