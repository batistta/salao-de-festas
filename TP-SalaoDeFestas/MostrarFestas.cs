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
    public partial class MostrarFestas : Form
    {
        List<Festa> festas;
        int festaAtual = 0;
        bool data = false;
        string cod;
        Contrato referente;
        public MostrarFestas(string filtro, string codigo, int metodo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            nomecl.Text = filtro;
            if (metodo == 0)
            {
                festas = ArqManager.ListarFestas(codigo, 6);
            } else
            {
                festas = ArqManager.ListarFestas(codigo, 2);
                data = true;
                bcancel.Enabled = false;
                bpagar.Enabled = false;
            }
            cod = codigo;
            AtualizaInterface();
        }
        public void AtualizaInterface()
        {
            if (festas.Count > 0)
            {
                referente = ArqManager.LerContratos(festas[festaAtual].codcl + "." + festas[festaAtual].codigo)[0];
                atfesta.Text = "" + (festaAtual + 1);
                totfesta.Text = "" + festas.Count;
                codfesta.Text = festas[festaAtual].codigo;
                convfesta.Text = "" + festas[festaAtual].convidados;
                inifesta.Text = festas[festaAtual].inicio;
                fimfesta.Text = festas[festaAtual].fim;
                datafesta.SelectionStart = DateTime.Parse(festas[festaAtual].data);
                datafesta.SelectionEnd = DateTime.Parse(festas[festaAtual].data);
            } else
            {
                if (data)
                {
                    MessageBox.Show("Não há festas para esta data!");
                }
                else
                {
                    MessageBox.Show("Não há festas para este cliente!");
                }
                this.Close();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (festaAtual > 0)
            {
                festaAtual--;
                AtualizaInterface();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (festaAtual < festas.Count-1)
            {
                festaAtual++;
                AtualizaInterface();
            }
        }

        private void atfesta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(atfesta.Text)-1 > 0 && int.Parse(atfesta.Text)-1 < festas.Count-1)
                {
                    festaAtual = int.Parse(atfesta.Text)-1;
                    AtualizaInterface();
                } else if (int.Parse(atfesta.Text) - 1 <= 0)
                {
                    atfesta.Text = "1";
                    festaAtual = 0;
                    AtualizaInterface();
                }
                else if (int.Parse(atfesta.Text) - 1 >= festas.Count - 1)
                {
                    atfesta.Text = totfesta.Text;
                    festaAtual = festas.Count-1;
                    AtualizaInterface();
                }
            } catch (Exception)
            {
                
            }
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            referente.Cancelar();
            ArqManager.AtualizaContratos(referente);
            MessageBox.Show("Cancelado!");
        }

        private void bpagar_Click(object sender, EventArgs e)
        {
            referente.Pagar();
            ArqManager.AtualizaContratos(referente);
            MessageBox.Show("Pago!");
        }

        private void verc_Click(object sender, EventArgs e)
        {
            VerContrato vc = new VerContrato();
            vc.DefinirContrato(referente);
            vc.Show();
        }
    }
}
