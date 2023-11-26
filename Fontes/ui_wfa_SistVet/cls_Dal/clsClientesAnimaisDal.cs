using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cls_modelo;

namespace cls_Dal
{
    public class clsClientesAnimaisDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandosSql;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public void Inserir(int cliId, int aniId)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "INSERT INTO tblAnimaisClientes (cliid, aniid) " +
                                       "VALUES (@cliid, @aniid)";

            _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = cliId;
            _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = aniId;

            _comandosSql.ExecuteNonQuery();

            Conexao.FecharConexao();
        }

        public void Remover(int cliId, int aniId)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.ObterConexao();

            _comandosSql = new SqlCommand();
            _comandosSql.Connection = _conexao;
            _comandosSql.CommandText = "DELETE FROM tblAnimaisClientes WHERE cliid = @cliid AND aniid = @aniid";

            _comandosSql.Parameters.Add("@cliid", SqlDbType.Int).Value = cliId;
            _comandosSql.Parameters.Add("@aniid", SqlDbType.Int).Value = aniId;

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
                _comandosSql.CommandText = "SELECT A.*, C.cliid, C.clinome, C.clicpf, C.cliemail, C.clidatacadastro " +
                                           "FROM tblAnimaisClientes AS AC " +
                                           "INNER JOIN tblClientes AS C ON AC.cliid = C.cliid " +
                                           "INNER JOIN tblAnimais AS A ON AC.aniid = A.aniid " +
                                           "ORDER BY A.aniid";

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
        public List<clsAnimaisClientes> listarTodosArray()
        {
            List<clsAnimaisClientes> clienteAnimais = new List<clsAnimaisClientes>();
            SqlDataReader _reader;

            try
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.ObterConexao();
                _comandosSql = new SqlCommand();
                _comandosSql.Connection = _conexao;
                _comandosSql.CommandText = "SELECT ac.cliid, c.clinome, ac.aniid, a.aninome " +
                                           "FROM tblAnimaisClientes ac " +
                                           "INNER JOIN tblClientes c ON ac.cliid = c.cliid " +
                                           "INNER JOIN tblAnimais a ON ac.aniid = a.aniid";

                _reader = _comandosSql.ExecuteReader();

                while (_reader.Read())
                {
                    clsAnimaisClientes item = new clsAnimaisClientes();
                    item.ClienteId = Convert.ToInt32(_reader["cliid"]);
                    item.ClienteNome = _reader["clinome"].ToString();
                    item.AnimalId = Convert.ToInt32(_reader["aniid"]);
                    item.AnimalNome = _reader["aninome"].ToString();

                    clienteAnimais.Add(item);
                }
                _reader.Close();
                return clienteAnimais;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
