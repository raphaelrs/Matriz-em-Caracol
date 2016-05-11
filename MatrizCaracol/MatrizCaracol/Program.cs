using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrizCaracol
{
    class Program
    {

        static void Main(string[] args)
        {
            string novo = "y";

            while (novo == "y")
            {
                Console.WriteLine("Informe o numero de linhas : ");
                Calculos.Linhas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n Informe o numero de colunas : ");
                Calculos.Colunas = Convert.ToInt32(Console.ReadLine());

                Calculos.Matriz = new int?[Calculos.Linhas, Calculos.Colunas];
                Calculos.Direcao = Direcao.Direita;
                Calculos.X = 0;
                Calculos.Y = 0;

                int qtd = Calculos.Linhas * Calculos.Colunas;


                for (int i = 0; i < qtd; i++)
                {
                    if (!Calculos.Salvar(i))
                    {
                        i--;
                    }
                }

                Console.Clear();
                Console.Write(" ");

                for (int i = 0; i < Calculos.Colunas; i++)
                {                    
                    Console.Write("____");
                }
                Console.WriteLine();
                for (int i = 0; i < Calculos.Linhas; i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < Calculos.Colunas; j++)
                    {
                        if (j < Calculos.Colunas -1)
                        {
                            if (Calculos.Matriz[i, j] < 10)
                            {
                                Console.Write(Calculos.Matriz[i, j] + "   ");
                            }
                            else
                            {
                                Console.Write(Calculos.Matriz[i, j] + "  ");
                            }
                        }
                        else
                        {
                            Console.Write(Calculos.Matriz[i, j] + "  ");
                        }
                    }
                    Console.Write("|\n");
                }

                Console.Write(" ");
                for (int i = 0; i < Calculos.Colunas; i++)
                {
                    Console.Write("____");
                }

                Console.WriteLine("\n\nInforme y para continuar");
                novo = Console.ReadLine();

                Console.Clear();
            } 
        }
    }
}
