using cls_modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_Dal
{
    public class clsAnimaisDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandosSql;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        private int ObterProximoId()
        {
            _conexao = new SqlConnection("Data Source=DESKTOP-4DS5K76\\SQLEXPRESS;" +
                            "Initial Catalog=dbsistvet2023;" +
                            "Integrated Security=True");
            _conexao.Open(); // Abra a conexão
            int codigo = 0;
            try
            {
                using (_comandosSql = new SqlCommand())
                {
                    // Verifique se _conexao não é nula e está aberta
                    if (_conexao != null && _conexao.State == ConnectionState.Open)
                    {
                        _comandosSql.Connection = _conexao;
                        _comandosSql.CommandText = "select isnull(max(aniid), 0) + 1 as codigo from tblAnimais ";
                        codigo = (int)_comandosSql.ExecuteScalar();
                    }
                    else
                    {
                        throw new InvalidOperationException("A conexão não está disponível ou não está aberta.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Lidar com exceções
                throw new Exception("Ocorreu um erro ao obter o próximo ID: " + ex.Message);
            }
            finally
            {
                // Certifique-se de que a conexão seja fechada, independentemente de sucesso ou exceção
                Conexao.FecharConexao();
            }

            return codigo;
        }

        public void inserir(clsAnimais parAnimal)
        {
            int codigo = ObterProximoId();
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();
            

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid) " +
                                       "VALUES (@aniid, @aninome, @aniapelido, @anidatanasc, @aniobservacoes, @aniespid)";

            _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = codigo;
            _comandosSql.Parameters.Add("@aninome", SqlDbType.VarChar).Value = parAnimal.Nome;
            _comandosSql.Parameters.Add("@aniapelido", SqlDbType.VarChar).Value = parAnimal.Apelido;
            _comandosSql.Parameters.Add("@anidatanasc", SqlDbType.Date).Value = parAnimal.Data;
            _comandosSql.Parameters.Add("@aniobservacoes", SqlDbType.VarChar).Value = parAnimal.Obs;
            _comandosSql.Parameters.Add("@aniespid", SqlDbType.Int).Value = parAnimal.AniEspeciesId;

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Atualizar(clsAnimais parAnimal)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "UPDATE tblAnimais " +
                                       "SET aniid = @aniid, " +
                                       "aninome = @aninome, " +
                                       "aniapelido = @aniapelido, " +
                                       "anidatanasc = @anidatanasc, " +
                                       "aniobservacoes = @aniobservacoes, " +
                                       "aniespid = @aniespid " +
                                       "WHERE aniid = @aniid";

            _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimal.Id;
            _comandosSql.Parameters.Add("@aninome", SqlDbType.VarChar).Value = parAnimal.Nome;
            _comandosSql.Parameters.Add("@aniapelido", SqlDbType.VarChar).Value = parAnimal.Apelido;
            _comandosSql.Parameters.Add("@anidatanasc", SqlDbType.Date).Value = parAnimal.Data;
            _comandosSql.Parameters.Add("@aniobservacoes", SqlDbType.VarChar).Value = parAnimal.Obs;
            _comandosSql.Parameters.Add("@aniespid", SqlDbType.Int).Value = parAnimal.AniEspeciesId;

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Excluir(clsAnimais parAnimal)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "DELETE tblAnimais " +
                                       "WHERE aniid = @aniid";
            _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimal.Id;
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
                _comandosSql.CommandText = "SELECT aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid " +
                                           "FROM tblAnimais " +
                                           "ORDER by aniid ";
                _tabela = new DataTable();
                _adaptador = new SqlDataAdapter(_comandosSql);
                _adaptador.Fill(_tabela);
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
        public List<clsAnimais> listarTodosArray()
        {
            List<clsAnimais> animais = new List<clsAnimais>();
            SqlDataReader _leitor;

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "SELECT aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid " +
                                           "FROM tblAnimais " +
                                           "ORDER by aniid ";

                _leitor = _comandosSql.ExecuteReader();

                while (_leitor.Read())
                {
                    clsAnimais item = new clsAnimais();
                    item.Id = Convert.ToInt32(_leitor["aniid"]);
                    item.Nome = _leitor["aninome"].ToString();
                    item.Apelido =_leitor["aniapelido"].ToString();
                    item.Data = Convert.ToDateTime(_leitor["anidatanasc"]);
                    item.Obs = _leitor["aniobservacoes"].ToString();
                    item.AniEspeciesId = Convert.ToInt32(_leitor["aniespid"]);

                    animais.Add(item);
                }
                _leitor.Close();
                return animais;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
        public List<clsAnimais> ListaAnimais()
        {
            List<clsAnimais> animal = new List<clsAnimais>();
            SqlDataReader _leitor;

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "SELECT aniid, aninome " +
                                           "FROM tblAnimais " +
                                           "ORDER by aniid ";

                _leitor = _comandosSql.ExecuteReader();

                while (_leitor.Read())
                {
                    clsAnimais item = new clsAnimais();
                    item.Id = Convert.ToInt32(_leitor["aniid"]);
                    item.Nome = _leitor["aninome"].ToString();
                   

                    animal.Add(item);
                }
                _leitor.Close();
                return animal;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
