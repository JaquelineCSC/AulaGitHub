using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFigura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> Lista_Figuras = new List<Figura>();
            Quadrado quadrado = null;
            Circulo circulo = null;
            Triangulo triangulo = null;
            int op = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1.Add Quadrado\n2.Add Triangulo\n3.Add Círculo\n4.Mostrar figura\n5.Sair");
                    Console.Write("Sua opção: ");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (op)
                    {
                        case 1:
                            quadrado = new Quadrado();
                            Console.Write("Nome: ");
                            quadrado.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            quadrado.Cor = Console.ReadLine();
                            Console.Write("Tamanho do lado: ");
                            quadrado.Lado = double.Parse(Console.ReadLine());
                            Lista_Figuras.Add(quadrado);
                            break;
                        case 2:
                            triangulo = new Triangulo();
                            Console.Write("Nome: ");
                            triangulo.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            triangulo.Cor = Console.ReadLine();
                            Console.Write("Altura: ");
                            triangulo.AlturaT = double.Parse(Console.ReadLine());
                            Console.Write("Base: ");
                            triangulo.BaseT = double.Parse(Console.ReadLine());
                            Lista_Figuras.Add(triangulo);
                            break;
                        case 3:
                            circulo = new Circulo();
                            Console.Write("Nome: ");
                            circulo.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            circulo.Cor = Console.ReadLine();
                            Console.Write("Raio: ");
                            circulo.Raio = double.Parse(Console.ReadLine());
                            Lista_Figuras.Add(circulo);
                            break;
                        case 4:
                            Console.Write("Nome da figura: ");
                            string nome_figura = Console.ReadLine();
                            bool achou = false;
                            foreach (Figura f in Lista_Figuras)
                            {
                                if (f.Nome == nome_figura)
                                {
                                    Console.Write("Nome: " + f.Nome + ", Cor: " + f.Cor + ", Área: " + f.Area().ToString("0.00"));
                                    achou = true;
                                    break;
                                }
                            }
                            if (!achou) { Console.Write("Figura não encontrada!"); }
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }

                } while (op != 5);
            }
            catch (Exception e)
            {
                Console.Write(">>> ERROR: " + e.Message);
                Console.ReadKey();
            }
            
        }
    }
}
