using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Repository
{
    public class BancoDados : IDisposable
    {
        private readonly SqlConnection conexao;

        public BancoDados()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
            conexao.Open();
        }

        public void ExecutaComando(string sql)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string sql)
        {
            var cmdComandoSelect = new SqlCommand(sql, conexao);
            return cmdComandoSelect.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
