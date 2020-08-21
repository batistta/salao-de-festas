using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SalaoDeFestas
{
    class ArqManager
    {
        /** Abre o arquivo de códigos (cliente, fornecedor ou funcionário)
         * e retorna o valor nele contido (código mais recente) */
        private static string LerCodigo(string arquivo)
        {
            FileStream arq = new FileStream(arquivo, FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string valor = ler.ReadLine();
            ler.Close();
            arq.Close();
            return valor;
        }
        /** Substitui o arquivo de código de cliente, fornecedor ou funcionário
         * por um novo arquivo com o código mais recente */
        private static void TrocarCodigo(string arquivo, int value)
        {
            FileStream arq = new FileStream(arquivo, FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);
            escrever.WriteLine(value);
            escrever.Close();
            arq.Close();
        }
        /** Busca o último código gerado para algum tipo de cadastro
         param tipo : arquivo desejado */
        private static int PegaUltimoCodigo(string tipo)
        {
            int cod = -1;
            switch (tipo)
            {
                case "cliente":
                    cod = int.Parse(LerCodigo("ultimo_cliente.txt")) + 1;
                    TrocarCodigo("ultimo_cliente.txt", cod);
                    break;
                case "funcionario":
                    cod = int.Parse(LerCodigo("ultimo_funcionario.txt")) + 1;
                    TrocarCodigo("ultimo_funcionario.txt", cod);
                    break;
                case "fornecedor":
                    cod = int.Parse(LerCodigo("ultimo_fornecedor.txt")) + 1;
                    TrocarCodigo("ultimo_fornecedor.txt", cod);
                    break;
                case "festa":
                    cod = int.Parse(LerCodigo("ultima_festa.txt")) + 1;
                    TrocarCodigo("ultima_festa.txt", cod);
                    break;
            }
            return cod;
        }
        /** Salva uma conta como cadastro para entrar futuramente */
        public static void CriaCadastro(string nome, string senha, string level)
        {
            FileStream arq = new FileStream("cadastros.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(nome + ";" + senha + ";" + level);
            escreve.Close();
            arq.Close();
        }
        /** Procura um cadastro com nome e senha correspondentes aos parâmetros */
        public static string LerCadastro(string nome, string senha)
        {
            FileStream arq = new FileStream("cadastros.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string valor, res = "erro";
            do
            {
                valor = ler.ReadLine();
                if (valor != null) {
                    string[] dados = valor.Split(';');
                    if (dados[0] == nome && dados[1] == senha)
                    {
                        res = dados[2];
                        break;
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return res;
        }
        /** Busca o código de um determinado cliente */
        public static string LerCodigoCliente(string nome)
        {
            FileStream arq = new FileStream("clientes.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string valor, res = "erro";
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    string[] dados = valor.Split(';');
                    if (dados[1] == nome)
                    {
                        res = dados[0];
                        break;
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return res;
        }
        public static void CriaCliente(string nome, string endereco,
            string telefone, string data_nasc)
        {
            FileStream arq = new FileStream("clientes.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(PegaUltimoCodigo("cliente") + ";" + nome + ";" + endereco + ";" + telefone + ";" + data_nasc.Split(',')[1]);
            escreve.Close();
            arq.Close();
        }
        public static void CriaFuncionario(string nome, string funcao,
            string salario, string telefone, string tipo)
        {
            FileStream arq = new FileStream("funcionarios.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(PegaUltimoCodigo("funcionario") + ";" + nome + ";" + telefone + ";" + funcao + ";" + salario + ";" + tipo);
            escreve.Close();
            arq.Close();
        }
        public static void CriaFornecedor(string nome, string telefone, string produto)
        {
            FileStream arq = new FileStream("fornecedores.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(PegaUltimoCodigo("fornecedor") + ";" + nome + ";" + telefone + ";" + produto);
            escreve.Close();
            arq.Close();
        }
        public static bool ExisteFesta(string data)
        {
            FileStream arq = new FileStream("festa.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor;
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    String[] dados = valor.Split(';');
                    if (dados[2] == data.Split(',')[1])
                    {
                        ler.Close();
                        arq.Close();
                        return true;
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return false;
        }
        public static Cliente PesquisarCliente(string nome)
        {
            FileStream arq = new FileStream("clientes.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor, cl = "-1;null;null;null;null";
            bool procurando = true;
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    String[] dados = valor.Split(';');
                    if (dados[1] == nome)
                    {
                        cl = valor;
                    }
                }
            } while (valor != null && procurando);
            ler.Close();
            arq.Close();
            return new Cliente(cl);
        }
        public static Funcionario PesquisarFuncionario(string nome)
        {
            FileStream arq = new FileStream("funcionarios.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor, cl = "-1;null;null;null;null;null";
            bool procurando = true;
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    String[] dados = valor.Split(';');
                    if (dados[1] == nome)
                    {
                        cl = valor;
                    }
                }
            } while (valor != null && procurando);
            ler.Close();
            arq.Close();
            return new Funcionario(cl);
        }
        public static List<Festa> ListarFestas(string codigoCliente, int metodo)
        {
            FileStream arq = new FileStream("festa.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor;
            List<Festa> festas = new List<Festa>();
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    //15;50; 13 de junho de 2018;quarta-feira;00:00 04:00;Morango;0
                    String[] dados = valor.Split(';');
                    if (dados[metodo] == codigoCliente)
                    {
                        festas.Add(new Festa(valor));
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return festas;
        }
        public static Fornecedor PesquisarFornecedor(string nome)
        {
            FileStream arq = new FileStream("fornecedores.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor, cl = "-1;null;null;null";
            bool procurando = true;
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    String[] dados = valor.Split(';');
                    if (dados[1] == nome)
                    {
                        cl = valor;
                    }
                }
            } while (valor != null && procurando);
            ler.Close();
            arq.Close();
            return new Fornecedor(cl);
        }
        public static String HoraLivre(string data)
        {
            FileStream arq = new FileStream("festa.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            String valor, retorno = "12:00";
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    String[] dados = valor.Split(';');
                    if (dados[2] == data.Split(',')[1])
                    {
                        if (dados[4].Split(' ')[0] == "12:00")
                        {
                            retorno = "18:00";
                        }
                        if (dados[4].Split(' ')[0] == "18:00")
                        {
                            retorno = "nenhum";
                            ler.Close();
                            arq.Close();
                            return retorno;
                        }
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return retorno;
        }
        private static int DiaCod(String dia)
        {
            int cod = -1;
            switch (dia)
            {
                case "segunda-feira":
                    cod = 0;
                    break;
                case "terça-feira":
                    cod = 1;
                    break;
                case "quarta-feira":
                    cod = 2;
                    break;
                case "quinta-feira":
                    cod = 3;
                    break;
                case "sexta-feira":
                    cod = 4;
                    break;
                case "sábado":
                    cod = 5;
                    break;
                case "domingo":
                    cod = 6;
                    break;
            }
            return cod;
        }
        private static String SelecionarPreco(String dia, int qtdPessoas)
        {
            String price = "";
            Console.WriteLine("Qtd: " + qtdPessoas);
            if (DiaCod(dia) < 4)
            {
                if (qtdPessoas >= 30 && qtdPessoas < 50) 
                {
                    price = "R$ 1899,00";
                }
                if (qtdPessoas >= 50 && qtdPessoas < 80)
                {
                    price = "R$ 2199,00";
                }
                if (qtdPessoas >= 80 && qtdPessoas < 100)
                {
                    price = "R$ 3199,00";
                }
                if (qtdPessoas >= 100)
                {
                    price = "R$ 3799,00";
                }
            } else
            {
                if (qtdPessoas >= 30 && qtdPessoas < 50)
                {
                    price = "R$ 2099,00";
                }
                if (qtdPessoas >= 50 && qtdPessoas < 80)
                {
                    price = "R$ 2299,00";
                    Console.WriteLine("aaa " + qtdPessoas);
                }
                if (qtdPessoas >= 80 && qtdPessoas < 100)
                {
                    price = "R$ 3499,00";
                }
                if (qtdPessoas >= 100)
                {
                    price = "R$ 3999,00";
                }
            }
            return price;
        }
        private static double TrueValue(string price)
        {
            return double.Parse(price.Split(' ')[1]);
        }
        private static string MaskedValue(double price)
        {
            return "R$ " + price;
        }
        private class DescontoHandler
        {
            public double priceOriginal, priceDesconto, contDesconto;
            public string desconto;
            public DescontoHandler(string price, string formapgto)
            {
                this.priceOriginal = TrueValue(price);
                switch (formapgto)
                {
                    case "À vista":
                        contDesconto = 0.1;
                        desconto = "10%";
                        break;
                    case "Duas vezes":
                        contDesconto = 0.05;
                        desconto = "5%";
                        break;
                    case "Três vezes":
                        contDesconto = 0.02;
                        desconto = "2%";
                        break;
                    default:
                        contDesconto = 0;
                        desconto = "0%";
                        break;
                }
                if (contDesconto > 0)
                {
                    priceDesconto = (priceOriginal) - (priceOriginal * contDesconto);
                } else
                {
                    priceDesconto = priceOriginal;
                }
            }
        }
        public static void CriaContrato(int codCliente, int codFesta, string valorTotal, 
            string formapgto)
        {
            Console.WriteLine(valorTotal);
            FileStream arq = new FileStream("contrato.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            DescontoHandler preco = new DescontoHandler(valorTotal, formapgto);
            escreve.WriteLine((codCliente + "." + codFesta) + ";" + MaskedValue(preco.priceOriginal) + ";" +
               preco.desconto + ";" + MaskedValue(preco.priceDesconto) + ";" +
               formapgto + ";" + "a pagar" + ";" + codFesta);
            escreve.Close();
            arq.Close();
        }
        public static String CriaFesta(String nome, int qtd, String data, String hora,
            String tema, int cod, String formapgto)
        {
            if (data.Split(',')[0] == "sábado")
            {
                if (HoraLivre(data) == "nenhum")
                {
                    return "existe-festa";
                } else if
                    (HoraLivre(data) != hora.Split(' ')[0])
                {
                    return "existe-festa";
                }
            }
            else
            {
                if (ExisteFesta(data))
                {
                    return "existe-festa";
                }
            }
            FileStream arq = new FileStream("festa.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            int codFesta = PegaUltimoCodigo("festa");
            escreve.WriteLine(codFesta + ";" + qtd + ";" + data.Split(',')[1] + ";" + data.Split(',')[0] + ";"
                + hora + ";" + tema + ";" + cod);
            escreve.Close();
            arq.Close();
            Console.WriteLine("" + qtd);
            CriaContrato(cod, codFesta, SelecionarPreco(data.Split(',')[0], qtd), formapgto);
            return "sucesso";
        }
        public static List<Contrato> LerContratos(string codigo)
        {
            Console.WriteLine("Codigo: " + codigo);
            FileStream arq = new FileStream("contrato.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string valor;
            List < Contrato > contratos = new List<Contrato>();
            do
            {
                valor = ler.ReadLine();
                if (valor != null)
                {
                    if (codigo == "")
                    {
                        contratos.Add(new Contrato(valor));
                    }
                    else
                    {
                        string[] dados = valor.Split(';');
                        if (dados[0] == codigo)
                        {
                            contratos.Add(new Contrato(valor));
                            break;
                        }
                    }
                }
            } while (valor != null);
            ler.Close();
            arq.Close();
            return contratos;
        }
        public static void AtualizaContratos(Contrato atualizado)
        {
            List<Contrato> contratos = LerContratos("");
            FileStream arq = new FileStream("contrato.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);
            foreach (Contrato contrato in contratos)
            {
                if (contrato.codcontrato == atualizado.codcontrato)
                {
                    escreve.WriteLine(atualizado.GerarDados());
                } else
                {
                    escreve.WriteLine(contrato.GerarDados());
                }
            }
            escreve.Close();
            arq.Close();
        }
    }
}
