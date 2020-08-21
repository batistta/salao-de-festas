using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SalaoDeFestas
{
    public partial class Form1 : Form
    {
        TextBox nome, senha;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ini_senha_TextChanged(object sender, EventArgs e)
        {
            this.senha = (TextBox)sender;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro cad = new TelaCadastro();
            cad.ShowDialog();
        }

        private void ini_entrar_Click(object sender, EventArgs e)
        {
            String level = ArqManager.LerCadastro(ini_name.Text, ini_senha.Text);
            if (level != "erro")
            {
                Principal tela = new Principal(ini_name.Text, level);
                tela.Show();
                //this.Hide();
            } else
            {
                MessageBox.Show("Usuário inexistente ou senha incorreta!");
            }
        }

        private void ini_name_TextChanged(object sender, EventArgs e)
        {
            this.nome = (TextBox)sender;
        }
    }
}
