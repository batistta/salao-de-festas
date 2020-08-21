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
    public partial class CadastrarFuncionario : Form
    {
        string tipo = "Temporário";
        public CadastrarFuncionario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void f_cadastrar_Click(object sender, EventArgs e)
        {
            string errorMessage = "Os seguintes campos devem ser preenchidos:\n";
            bool error = false;
            if (f_nome.Text.Length == 0)
            {
                errorMessage += "Nome\n";
                error = true;
            }
            if (!f_tel.MaskCompleted)
            {
                errorMessage += "Telefone\n";
                error = true;
            }
            if (f_func.Text.Length == 0)
            {
                errorMessage += "Função\n";
                error = true;
            }
            if (f_sal.Text.Length == 0)
            {
                errorMessage += "Salário\n";
                error = true;
            }
            if (f_pass.Text.Length == 0)
            {
                errorMessage += "Senha";
                error = true;
            }
            if (!error)
            {
                ArqManager.CriaCadastro(f_nome.Text, f_pass.Text, "funcionario");
                ArqManager.CriaFuncionario(f_nome.Text, f_func.Text,
                    f_sal.Text, f_tel.Text, tipo);
                MessageBox.Show("Cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Fixo";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Temporário";
        }
    }
}
