using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.bd_
{
    internal class db_conf
    {
        private static readonly string conf =
            "server=localhost;userid=root;pwd=123456;database=mysqldotnet;";

        private readonly MySqlConnection conexao;

        public db_conf()
        {
            conexao = new MySqlConnection(conf);
        }

        public MySqlConnection GetConexao() => conexao;

        public void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
                conexao.Open();
        }

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
    }
}
