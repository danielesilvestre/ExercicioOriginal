using Business.Uteis;
using Exercicio;
using Service;
using System;
using System.Globalization;

namespace ExercicioConsole
{
    class Program : Master
    {
        static void Main(string[] args)
        {

            string valor = "0";
            do
            {
                try
                {
                    RetornaMenu();
                    valor = Console.ReadLine();

                    switch ((ItensMenu)Convert.ToInt32(valor))
                    {
                        case ItensMenu.ListarTodosLivros:
                            ListarTodosLivros();
                            break;

                        case ItensMenu.ListarAutores:
                            ListarAutores();
                            break;

                        case ItensMenu.ListarTitulos:
                            ListarTitulos();
                            break;

                        case ItensMenu.ListarTemas:
                            ListarTemas();
                            break;

                        case ItensMenu.PesquisarLivrosPorTema:
                            PesquisarLivrosPorTema();
                            break;

                        case ItensMenu.PesquisarLivrosPorAutor:
                            PesquisarLivrosPorAutor();
                            break;
                    }

                    Console.WriteLine("Aperte enter para continuar!");
                    Console.ReadLine();

                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao tentar processar!\nAcione a equipe técnica!\n" + ex.Message);
                    Console.ReadLine();
                }


            } while (valor != "0");


            Console.WriteLine("*****************************");


        }

        public static void ListarTodosLivros()
        {
            Console.Clear();
            var service = new LivrariaService();
            var listarLivros = service.ObterLivros();
            Console.WriteLine("******Livros******");

            if (listarLivros.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {


                foreach (var item in listarLivros)
                {
                    Console.WriteLine("Autor: " + item.Autor);
                    Console.WriteLine("Titulo: " + item.Titulo);
                    Console.WriteLine("Valor: " + item.Valor.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Tema: " + item.Tema.Descricao);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        public static void ListarAutores()
        {
            Console.Clear();
            Console.WriteLine("******Autores******\n");

            var service = new LivrariaService();
            var listarAutores = service.ObterAutores();

            if (listarAutores.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {

                foreach (var item in listarAutores)
                {
                    Console.WriteLine(item.Autor);

                }
                Console.WriteLine();
            }

        }

        public static void ListarTitulos()
        {
            Console.Clear();
            Console.WriteLine("******Titulos******\n");

            var service = new LivrariaService();
            var listarTitulos = service.ObterTitulos();

            if (listarTitulos.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {
                foreach (var item in listarTitulos)
                {
                    Console.WriteLine(item.Titulo);
                }
                Console.WriteLine();
            }

        }

        public static void ListarTemas()
        {
            Console.Clear();
            Console.WriteLine("******Temas******\n");

            var service = new LivrariaService();
            var listarTemas = service.ObterTemas();

            if (listarTemas.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {
                foreach (var item in listarTemas)
                {
                    Console.WriteLine(item.Descricao);
                }

                Console.WriteLine();
            }
        }

        public static void PesquisarLivrosPorTema()
        {

            Console.Clear();
            Console.Write("Digite o tema a ser pesquisado: ");
            string tema = Console.ReadLine();
            Console.WriteLine("******Livros******");

            var service = new LivrariaService();
            var PesquisarPorTema = service.ObterLivrosPorTema(tema);

            if (PesquisarPorTema.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {
                foreach (var item in PesquisarPorTema)
                {
                    Console.WriteLine("Codigo: " + item.Id);
                    Console.WriteLine("Titulo: " + item.Titulo);
                    Console.WriteLine("Autor: " + item.Autor);
                    Console.WriteLine("Valor: " + item.Valor.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Tema: " + item.Tema.Descricao);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        public static void PesquisarLivrosPorAutor()
        {

            Console.Clear();
            Console.Write("Digite o nome do Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("******Livros******");

            var service = new LivrariaService();
            var ListaPorAutor = service.ObterLivrosPorAutor(autor);

            if (ListaPorAutor.Count < 1)
            {
                Console.WriteLine("Nenhum valor encontrado");
            }
            else
            {
                foreach (var item in ListaPorAutor)
                {
                    Console.WriteLine("Codigo: " + item.Id);
                    Console.WriteLine("Titulo: " + item.Titulo);
                    Console.WriteLine("Autor: " + item.Autor);
                    Console.WriteLine("Valor: " + item.Valor.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Tema: " + item.Tema.Descricao);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
