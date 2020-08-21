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
    public partial class CadastrarFesta : Form
    {
        int cod;
        public CadastrarFesta(String cliente, int codigo)
        {
            InitializeComponent();
            textBox3.Text = cliente;
            cod = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.formapagamento.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (datafesta.Text.Split(',')[0] == "sábado")
            {
                String hora = ArqManager.HoraLivre(datafesta.Text);
                inif.ReadOnly = true;
                if (hora != "nenhum")
                {
                    inif.Text = hora;
                }
                else
                {
                    MessageBox.Show("Não há horários disponíveis para este sábado!");
                    datafesta.BackColor = Color.Red;
                }
            }
            else
            {
                inif.ReadOnly = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArqManager.CriaFesta(textBox3.Text,
                int.Parse(numconvidados.Text),
                datafesta.Text,
                (inif.Text + " " + fimf.Text),
                temafesta.Text,
                cod,
                formapagamento.Text) == "sucesso")
            {
                MessageBox.Show("Festa cadastrada com sucesso!");
            } else
            {
                MessageBox.Show("Já existe uma festa para a data selecionada!");
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void inif_TextChanged(object sender, EventArgs e)
        {
            if (inif.MaskCompleted)
            {
                if ((int.Parse((inif.Text.Split(':')[0])) + 4) <= 9)
                {
                    fimf.Text = "0" + (int.Parse((inif.Text.Split(':')[0])) + 4) + inif.Text.Split(':')[1];
                }
                else
                {
                    fimf.Text = (int.Parse((inif.Text.Split(':')[0])) + 4) + inif.Text.Split(':')[1];
                }
            }
        }

        private void temafesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
