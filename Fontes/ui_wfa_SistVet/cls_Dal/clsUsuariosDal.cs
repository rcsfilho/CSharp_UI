using cls_modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cls_Dal
{
    public class clsUsuariosDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandosSql;
        private DataTable _tabela;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private DataTable _validacao;

        private int ObterProximoId()
        {
            int codigo = 0;
            try
            {
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText =
                    "SELECT ISNULL(MAX(usuid), 0) + 1 AS codigo FROM tblUsuarios";
                codigo = Convert.ToInt32(_comandosSql.ExecuteScalar());
                return codigo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Inserir(clsUsuarios parUsuario)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();
            int codigo = ObterProximoId();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "INSERT INTO tblUsuarios (usuid, usunome, usulogin, ususenha, usuemail, usuobservacoes) " +
                                       "VALUES (@usuid, @usunome, @usulogin, @ususenha, @usuemail, @usuobservacoes)";

            _comandosSql.Parameters.Add("@usuid", SqlDbType.Int).Value = codigo;
            _comandosSql.Parameters.Add("@usunome", SqlDbType.VarChar).Value = parUsuario.Nome;
            _comandosSql.Parameters.Add("@usulogin", SqlDbType.VarChar).Value = parUsuario.Login;
            _comandosSql.Parameters.Add("@ususenha", SqlDbType.VarChar).Value = parUsuario.Senha;
            _comandosSql.Parameters.Add("@usuemail", SqlDbType.VarChar).Value = parUsuario.Email;
            _comandosSql.Parameters.Add("@usuobservacoes", SqlDbType.VarChar).Value = parUsuario.Observ;

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Atualizar(clsUsuarios parUsuario)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "UPDATE tblUsuarios " +
                                       "SET usunome = @usunome, " +
                                       "usulogin = @usulogin, " +
                                       "ususenha = @ususenha, " +
                                       "usuemail = @usuemail, " +
                                       "usuobservacoes = @usuobservacoes " +
                                       "WHERE usuid = @usuid";

            _comandosSql.Parameters.Add("@usuid", SqlDbType.Int).Value = parUsuario.Id;
            _comandosSql.Parameters.Add("@usunome", SqlDbType.VarChar).Value = parUsuario.Nome;
            _comandosSql.Parameters.Add("@usulogin", SqlDbType.VarChar).Value = parUsuario.Login;
            _comandosSql.Parameters.Add("@ususenha", SqlDbType.VarChar).Value = parUsuario.Senha;
            _comandosSql.Parameters.Add("@usuemail", SqlDbType.VarChar).Value = parUsuario.Email;
            _comandosSql.Parameters.Add("@usuobservacoes", SqlDbType.VarChar).Value = parUsuario.Observ;

           

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Excluir(clsUsuarios parUsuario)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "DELETE tblUsuarios " +
                                       "WHERE usuid = @usuid";
            _comandosSql.Parameters.Add("@usuid", SqlDbType.Int).Value = parUsuario.Id;
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
                _comandosSql.CommandText = "select usuid, usunome, usulogin, ususenha, usuemail, usuobservacoes " +
                                           " from tblUsuarios " +
                                           " order by usuid ";
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
        public List<clsUsuarios> listarTodosArray()
        {
            List<clsUsuarios> usuario = new List<clsUsuarios>();

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "select usuid, usunome, usulogin, ususenha, usuemail, usuobservacoes " +
                                           " from tblUsuarios " +
                                           " order by usuid ";
                _reader = _comandosSql.ExecuteReader();

                while (_reader.Read())
                {
                    clsUsuarios item = new clsUsuarios();
                    item.Id = Convert.ToInt32(_reader["usuid"]);
                    item.Nome = _reader["usunome"].ToString();
                    item.Login = _reader["usulogin"].ToString();
                    item.Senha = _reader["ususenha"].ToString();
                    item.Email = _reader["usuemail"].ToString();
                    item.Observ = _reader["usuobservacoes"].ToString();

                    usuario.Add(item);
                }
                _reader.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
        public DataTable Validacao()
        {
            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "select usulogin, ususenha" +
                                           " from tblUsuarios ";                                          
                _validacao = new DataTable();
                _adapter = new SqlDataAdapter(_comandosSql);
                _adapter.Fill(_validacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return _validacao;
        }
    }
}

    

