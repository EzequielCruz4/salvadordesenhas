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

        private void bsalvar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string endereco = textBox2.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nome = nome,
                Endereco = endereco
            };

            usuarioDAO.Inserir(usuario);

            CarregarTabela();
        }

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
    }
}

