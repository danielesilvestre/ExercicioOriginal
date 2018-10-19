using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Master
    {
        public static void RetornaMenu()
        {
            var exibirMenu = ConfigurationSettings.AppSettings.Get("IdVerMenu");
            Console.Clear();
            Console.WriteLine("****************** Biblioteca ******************");
            Console.WriteLine("*                                              *");
            Console.WriteLine("********************* Menu *********************");

            foreach (var item in exibirMenu.Split(',').ToList())
            {
                switch (Convert.ToInt32(item))
                {
                    case 1:
                        Console.WriteLine("* 1 Listar todos os Livros com seus conteudos  *");
                        break;
                    case 2:
                        Console.WriteLine("* 2 Listar Apenas Autores                      *");
                        break;
                    case 3:
                        Console.WriteLine("* 3 Listar Apenas Titulo                       *");
                        break;
                    case 4:
                        Console.WriteLine("* 4 Listar Temas                               *");
                        break;
                    case 5:
                        Console.WriteLine("* 5 Pesquisar Livros por Temas                 *");
                        break;
                    case 6:
                        Console.WriteLine("* 6 Pesquisar Livros por Autor                 *");
                        break;
                }
            }


            Console.WriteLine("* 0 Exit                                       *");
            Console.WriteLine("*                                              *");
            Console.WriteLine("************************************************");
            Console.WriteLine(" ");
        }
    }
}
