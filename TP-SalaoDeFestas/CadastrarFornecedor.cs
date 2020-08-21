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
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void cl_cadastrar_Click(object sender, EventArgs e)
        {
            string errorMessage = "Os seguintes campos devem ser preenchidos:\n";
            bool error = false;
            if (fo_nome.Text.Length == 0)
            {
                errorMessage += "Nome\n";
                error = true;
            }
            if (!fo_tel.MaskCompleted)
            {
                errorMessage += "Telefone\n";
                error = true;
            }
            if (fo_prod.Text.Length == 0)
            {
                errorMessage += "Produto fornecido\n";
                error = true;
            }
            if (fo_pass.Text.Length == 0)
            {
                errorMessage += "Senha";
                error = true;
            }
            if (!error)
            {
                ArqManager.CriaCadastro(fo_nome.Text, fo_pass.Text, "fornecedor");
                ArqManager.CriaFornecedor(fo_nome.Text, fo_tel.Text, fo_prod.Text);
                MessageBox.Show("Cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
