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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void cl_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cl_cadastrar_Click(object sender, EventArgs e)
        {
            string errorMessage = "Os seguintes campos devem ser preenchidos:\n";
            bool error = false;
            if (cl_nome.Text.Length == 0)
            {
                errorMessage += "Nome\n";
                error = true;
            }
            if (cl_endereco.Text.Length == 0)
            {
                errorMessage += "Endereço\n";
                error = true;
            }
            if (!cl_tel.MaskCompleted)
            {
                errorMessage += "Telefone\n";
                error = true;
            }
            if (cl_senha.Text.Length == 0)
            {
                errorMessage += "Senha";
                error = true;
            }
            if (!error)
            {
                ArqManager.CriaCadastro(cl_nome.Text, cl_senha.Text, "cliente");
                ArqManager.CriaCliente(cl_nome.Text, cl_endereco.Text, cl_tel.Text, cl_data.Text);
                MessageBox.Show("Cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void cl_tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
