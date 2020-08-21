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
    public partial class Principal : Form
    {
        String level, code;
        public Principal(String nome, String level)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.level = level;
            switch (level)
            {
                case "cliente":
                    code = ArqManager.LerCodigoCliente(nome);
                    lvl.Text = "Cliente";
                    button1.Enabled = false;
                    button4.Enabled = false;
                    break;
                case "fornecedor":
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    lvl.Text = "Fornecedor";
                    break;
                case "funcionario":
                    button2.Enabled = false;
                    button3.Enabled = false;
                    lvl.Text = "Funcionário";
                    break;
            }
            label2.Text = nome;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarFesta cf = new CadastrarFesta(label2.Text, int.Parse(code));
            cf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibirClientes cls = new ExibirClientes();
            cls.Show();
            //MessageBox.Show((ArqManager.PesquisarCliente("Luket") as Cliente).nome);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BuscaFesta().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFestas mf = new MostrarFestas(label2.Text, code, 0);
            mf.Show();
        }
    }
}
