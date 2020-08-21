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
    public partial class BuscaFesta : Form
    {
        public BuscaFesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFestas mf = new MostrarFestas(data.Text.Split(',')[1], data.Text.Split(',')[1], 1);
            try
            {
                mf.Show();
            }
            catch (Exception) { }
        }
    }
}
