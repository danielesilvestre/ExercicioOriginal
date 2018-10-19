using Model.Model;
using System.Collections.Generic;

namespace Model.Repository
{
    public class LivrariaRepository
    {
        public List<LivroModel> ObterLivros()
        {
            return new List<LivroModel>
            {
                new LivroModel
                {
                    Id = 1,
                    Autor = "Felipe",
                    Titulo = "Poeira em Alto Mar",
                    Valor = 100.40,
                    Tema = new TemaLivroModel { Id = 1, Descricao = "Suspense" }
                },
                new LivroModel
                {
                    Id = 2,
                    Autor = "Amanda",
                    Titulo = "As Tranças do Rei Careca",
                    Valor = 60.40,
                    Tema = new TemaLivroModel { Id = 2, Descricao = "Romance" }
                },
                new LivroModel
                {
                    Id = 3,
                    Autor = "Ailton",
                    Titulo = "Helicóptero doido",
                    Valor = 40.40,
                    Tema = new TemaLivroModel { Id = 3, Descricao = "Ação" }
                },
                new LivroModel
                {
                    Id = 4,
                    Autor = "Bitar",
                    Titulo = "Poeira no Rio",
                    Valor = 50.48,
                    Tema = new TemaLivroModel { Id = 1, Descricao = "Suspense" }
                },
                new LivroModel
                {
                    Id = 5,
                    Autor = "Vinicius",
                    Titulo = "Bla bla Pombo",
                    Valor = 90.40,
                    Tema = new TemaLivroModel { Id = 3, Descricao = "Ação" }
                },

            };
        }
    }
}
