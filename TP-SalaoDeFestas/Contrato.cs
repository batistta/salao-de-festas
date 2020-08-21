using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class Contrato
    {
        public string codcontrato, preco, desc, precodesc, metodo, pgto, codfesta;
        public Contrato(string dados)
        {
            string[] d = dados.Split(';');
            codcontrato = d[0];
            preco = d[1];
            desc = d[2];
            precodesc = d[3];
            metodo = d[4];
            pgto = d[5];
            codfesta = d[6];
        }
        public void Cancelar()
        {
            pgto = "Cancelado";
        }
        public void Pagar()
        {
            pgto = "Pago";
        }
        public string GerarDados()
        {
            return codcontrato + ";" + preco + ";" + desc + ";" + precodesc + ";" + metodo + ";" + pgto + ";" + codfesta;
        }
    }
}
