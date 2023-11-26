using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using cls_modelo;

namespace cls_Dal
{
    public class clsEspeciesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandosSql;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        private int ObterProximoId()
        {
            int codigo = 0;
            try
            {
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText =
                    "SELECT ISNULL(MAX(espid), 0) + 1 AS codigo FROM tblEspecies";
                codigo = Convert.ToInt32(_comandosSql.ExecuteScalar());
                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }
        public void inserir(clsEspecies parEspecie)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();
            int codigo = ObterProximoId();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "insert into tblEspecies values (@espid, @espnome)";
            _comandosSql.Parameters.Add("@espid", SqlDbType.Int).Value = codigo;
            _comandosSql.Parameters.Add("@espnome", SqlDbType.VarChar).Value = parEspecie.Nome;
            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Atualizar(clsEspecies parEspecie)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "UPDATE tblEspecies " +
                                       "SET espid = @espid, " +
                                       "espnome = @espnome " +
                                       "WHERE espid = @espid";
            _comandosSql.Parameters.Add("@espid", SqlDbType.Int).Value = parEspecie.Id;
            _comandosSql.Parameters.Add("@espnome", SqlDbType.VarChar).Value = parEspecie.Nome;

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Excluir(clsEspecies parEspecie)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "DELETE tblEspecies " +
                                       "WHERE espid = @espid";
            _comandosSql.Parameters.Add("@espid", SqlDbType.Int).Value = parEspecie.Id;

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
                _comandosSql.CommandText = "SELECT espid, espnome " +
                                           " FROM tblEspecies " +
                                           " ORDER by espid ";
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
        public List<clsEspecies> listarTodosArray()
        {
            List<clsEspecies> especies = new List<clsEspecies>();
            SqlDataReader _leitor;

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "select espid, espnome" +
                                           " from tblEspecies " +
                                           " order by espid ";

                _leitor = _comandosSql.ExecuteReader();

                while (_leitor.Read())
                {
                    clsEspecies item = new clsEspecies();
                    item.Id = Convert.ToInt32(_leitor["espid"]);
                    item.Nome = _leitor["espnome"].ToString();
                    
                    especies.Add(item);
                }
                _leitor.Close();
                return especies;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
        public List<clsEspecies> ObterTodasAsEspecies()
        {
            List<clsEspecies> especies = new List<clsEspecies>();
            SqlDataReader _leitor;

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "select espnome" +
                                           " from tblEspecies " +
                                           " order by espid ";

                _leitor = _comandosSql.ExecuteReader();

                while (_leitor.Read())
                {
                    clsEspecies item = new clsEspecies();                    
                    item.Nome = _leitor["espnome"].ToString();

                    especies.Add(item);
                }
                _leitor.Close();
                return especies;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
