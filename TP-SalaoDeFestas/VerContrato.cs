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
    public partial class VerContrato : Form
    {
        public VerContrato()
        {
            InitializeComponent();
        }

        public void DefinirContrato(object contrato)
        {
            Contrato c = contrato as Contrato;
            b1.Text = c.preco;
            b2.Text = c.desc;
            b3.Text = c.precodesc;
            b4.Text = c.metodo;
            b5.Text = c.pgto;
        }

        private void VerContrato_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
