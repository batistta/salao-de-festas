using System;
using System.Windows.Forms;

namespace TP_SalaoDeFestas
{
    public partial class ExibirClientes : Form
    {
        Cliente cliente;
        Funcionario func;
        Fornecedor forn;
        public ExibirClientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ExibirClientes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cliente = ArqManager.PesquisarCliente(textBox1.Text);
            if (cliente.codigo >= 0)
            {
                textBox2.Text = "" + cliente.codigo;
                textBox3.Text = cliente.endereco;
                textBox4.Text = cliente.telefone;
                textBox5.Text = cliente.data_nasc;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            func = ArqManager.PesquisarFuncionario(textBox6.Text);
            if (func.codigo >= 0)
            {
                textBox10.Text = "" + func.codigo;
                textBox9.Text = func.funcao;
                textBox8.Text = func.telefone;
                textBox7.Text = func.salario;
                textBox11.Text = func.tipo;
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forn = ArqManager.PesquisarFornecedor(textBox13.Text);
            if (forn.codigo >= 0)
            {
                textBox17.Text = "" + forn.codigo;
                textBox16.Text = forn.produto;
                textBox15.Text = forn.telefone;
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado!");
            }
        }
    }
}
