using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.bd_
{
    internal class UsuarioDAO
    {
        private readonly db_conf db;

        public UsuarioDAO()
        {
            db = new db_conf();
        }

        public void Inserir(Usuario usuario)
        {
            string query = "INSERT INTO usuario (nome, endereco) VALUES (@nome, @endereco)";

            try
            {
                db.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConexao()))
                {
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário inserido com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir usuário: {ex.Message}", "Erro");
            }
            finally
            {
                db.FecharConexao();
            }
        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            string query = "SELECT * FROM usuario";

            try
            {
                db.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConexao()))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar usuários: {ex.Message}", "Erro");
            }
            finally
            {
                db.FecharConexao();
            }

            return tabela;
        }
    }
}
