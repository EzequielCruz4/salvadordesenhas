using System;
using System.Windows.Forms;
using WinFormsApp1.bd_;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly UsuarioDAO usuarioDAO;

        public Form1()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
        }

        // BOTÃO SALVAR
        private void bsalvar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string endereco = textBox2.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso");
                return;
            }

            // Cria um objeto Usuario com os dados da tela
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Endereco = endereco
            };

            // Usa o DAO para inserir no banco
            usuarioDAO.Inserir(usuario);

            // Atualiza a tabela
            CarregarTabela();
        }

        // BOTÃO ENVIAR
        private void button1_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            dgNomes.DataSource = usuarioDAO.Listar();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgNomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
