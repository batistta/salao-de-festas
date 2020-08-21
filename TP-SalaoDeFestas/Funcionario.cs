using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class Funcionario
    {
        public int codigo;
        public string nome, telefone, funcao, salario, tipo;
        public Funcionario(String dados)
        {
            String[] d = dados.Split(';');
            codigo = int.Parse(d[0]);
            nome = d[1];
            telefone = d[2];
            funcao = d[3];
            salario = d[4];
            tipo = d[5];
        }
    }
}
