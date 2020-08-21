using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class Fornecedor
    {
        public int codigo;
        public string nome, telefone, produto;
        public Fornecedor(String dados)
        {
            String[] d = dados.Split(';');
            codigo = int.Parse(d[0]);
            nome = d[1];
            telefone = d[2];
            produto = d[3];
        }
    }
}
