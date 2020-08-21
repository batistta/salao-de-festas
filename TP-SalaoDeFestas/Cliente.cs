using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class Cliente
    {
        public int codigo;
        public string endereco, nome, telefone, data_nasc;
        public Cliente(String dados)
        {
            String[] d = dados.Split(';');
            codigo = int.Parse(d[0]);
            nome = d[1];
            endereco = d[2];
            telefone = d[3];
            data_nasc = d[4];
        }
    }
}
