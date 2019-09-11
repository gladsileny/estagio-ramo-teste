using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Teste 
    {
    class Program 
    {
        static void Main(string[] args) 
        {
            // Testar o código.
            try 
            {
                // Variavel contador para auxiliar na  contagem das linhas.
                int contador = 1;

                // Instancio a classe para realizar a leitura do arquivo.
                StreamReader Reader = new StreamReader(@"c:\Teste.csv");

                // Crio uma lista do tipo Pessoa para guardar os dados do arquivo.
                List<Pessoa> listPessoa = new List<Pessoa>();

                // Variavel para guardar uma linha do arquivo.
                string linha = null;

                // Utilizo o while para pegar cada linha.
                while ((linha = Reader.ReadLine()) != null) 
                {

                    // Condição para começar a guardar os dados, que começa a partir da segunda linha.
                    if (contador > 1) 
                    {
                        // Utilizo o método Split para quebrar a linha, cada parte será guardada em uma variavel.
                        string[] coluna = linha.Split(';');
                        int id = int.Parse(coluna[0]);
                        string nome = coluna[1];
                        double valor = double.Parse(coluna[2]);

                        // Crio um objeto p para guardar os dados da linha;.
                        Pessoa p = new Pessoa(id, nome, valor);
                        // Insiro o objeto na lista.
                        listPessoa.Add(p);
                    }
                    // Incrementação do contador.
                    contador++;
                }
                // Término da leitura do arquivo.
                Reader.Close();

                // Variavel que receberá a soma de todos os valores do arquivo.
                var total = listPessoa.Sum(c => c.Valor);

                // Crio uma lista do tipo Percent para guardar os percentuais e nomes.
                List<Percent> listPercent = new List<Percent>();

                // Utilizo um loop para calcular o percentual de cada um.
                foreach (var x in listPessoa) 
                {
                    // Cálculo do percentual.
                    double percentual = (100 * x.Valor) / total;
                    // Crio um objeto per para guardar os percentuais com seus respectivos nomes.
                    Percent per = new Percent(percentual, x.Nome);
                    // Insiro o objeto na lista.
                    listPercent.Add(per);
                }

                // Lista em ordem crescente de acordo com o percentual.
                listPercent = listPercent.OrderBy(y => y.Percentual).ToList();

                // Imprimo na tela a lista ordenada.
                Console.WriteLine("NOME \tPERCENTUAL");
                listPercent.ForEach(x => Console.WriteLine(x));

            }
            // Caso não funcione é exibido uma mensagem de erro.
            catch 
            {
                Console.WriteLine("ERRO!!!");
            }
        }
    }
}
