using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class Festa
    {
        public string codigo, inicio, fim, data, codcl;
        public int convidados;
        private string FormatDate(string date)
        {
            string dia = date.Split(' ')[1], mes = date.Split(' ')[3], ano = date.Split(' ')[5];
            switch (mes)
            {
                case "janeiro":
                    mes = "1";
                    break;
                case "fevereiro":
                    mes = "2";
                    break;
                case "março":
                    mes = "3";
                    break;
                case "abril":
                    mes = "4";
                    break;
                case "maio":
                    mes = "5";
                    break;
                case "junho":
                    mes = "6";
                    break;
                case "julho":
                    mes = "7";
                    break;
                case "agosto":
                    mes = "8";
                    break;
                case "setembro":
                    mes = "9";
                    break;
                case "outubro":
                    mes = "10";
                    break;
                case "novembro":
                    mes = "11";
                    break;
                case "dezembro":
                    mes = "12";
                    break;
            }
            return dia + "/" + mes + "/" + ano;
        }
        public Festa(string dados)
        {
            //15;50; 13 de junho de 2018;quarta-feira;00:00 04:00;Morango;0
            string[] d = dados.Split(';');
            codigo = d[0];
            convidados = int.Parse(d[1]);
            data = FormatDate(d[2]);
            inicio = d[4].Split(' ')[0];
            fim = d[4].Split(' ')[1];
            codcl = d[6];
        }
    }
}
