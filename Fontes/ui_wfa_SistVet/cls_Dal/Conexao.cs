using System.Data;
using System;
using System.Data.SqlClient;

namespace cls_Dal
{
    public class Conexao
    {
        private static SqlConnection _conexao;
        private static SqlCommand _comando;
        private static SqlDataAdapter _adaptador;
        private static SqlDataReader _reader;
        private static DataTable _tabela;

        private static String _stringConexao = "Data Source=DESKTOP-4DS5K76\\SQLEXPRESS;" +
                                                "Initial Catalog=dbsistvet2023;" +
                                                "Integrated Security=True";

        public static SqlConnection ObterConexao()
        {
            try
            {
                _conexao = new SqlConnection();
                _conexao.ConnectionString = _stringConexao;
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FecharConexao()
        {
            if (_conexao != null && _conexao.State == ConnectionState.Open)
            {
                _conexao.Close();
            }
        }
    }
}