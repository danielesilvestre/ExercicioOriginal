using Business.DTO;
using Model.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System;

namespace Business
{
    public class LivrariaBusiness
    {
        public List<LivroDTO> ObterLivros()
        {
            LivrariaRepository service = new LivrariaRepository();
            return service.ObterLivros().Select(p =>
            new LivroDTO
            {
                Autor = p.Autor,
                Id = p.Id,
                Titulo = p.Titulo,
                Valor = p.Valor,
                Tema = new TemaLivroDTO { Descricao = p.Tema.Descricao }

            }).ToList();
        }

        public List<LivroDTO> ObterAutores()
        {
            LivrariaRepository service = new LivrariaRepository();
            return service.ObterLivros().Select(p => new LivroDTO
            {
                Autor = p.Autor,
                Id = p.Id

            }).ToList();

        }

        public List<LivroDTO> ObterTitulos()
        {
            LivrariaRepository sevice = new LivrariaRepository();
            return sevice.ObterLivros().Select(p => new LivroDTO
            {
                Titulo = p.Titulo,
                Id = p.Id

            }
        ).ToList();
        }

        public List<TemaLivroDTO> ObterTemas()
        {
            LivrariaRepository service = new LivrariaRepository();
            var valida = service.ObterLivros().Select(p => new TemaLivroDTO
            {
                Descricao = p.Tema.Descricao,
                Id = p.Tema.Id

            }).ToList();

            List<TemaLivroDTO> lista = new List<TemaLivroDTO>();

            foreach (var item in valida)
            {
                if (!lista.Exists(p => p.Id == item.Id))
                {
                    lista.Add(item);
                }
            }

            return lista.ToList();

        }

        public List<LivroDTO> ObterLivrosPorTema(string tema)
        {
            ValidarPesquisas("tema", tema);
            
            LivrariaRepository service = new LivrariaRepository();

            return service.ObterLivros().Select(p => new LivroDTO()
            {
                Autor = p.Autor,
                Titulo = p.Titulo,
                Id = p.Id,
                Valor =  p.Valor,
                Tema = new TemaLivroDTO{Id = p.Tema.Id, Descricao = p.Tema.Descricao}

            }).Where(p => p.Tema.Descricao.ToUpper().Contains(tema.ToUpper())).ToList();


        }

        public List<LivroDTO> ObterLivrosPorAutor(string autor)
        {
            ValidarPesquisas("autor", autor);
            LivrariaRepository service = new LivrariaRepository();
            return service.ObterLivros().Select(p => new LivroDTO
            {
                Autor = p.Autor,
                Titulo = p.Titulo,
                Id = p.Id,
                Valor = p.Valor,
                Tema = new TemaLivroDTO {Id = p.Tema.Id, Descricao = p.Tema.Descricao }
               

            }).Where(p => p.Autor.ToUpper().Contains(autor.ToUpper())).ToList();
        }

        public void ValidarPesquisas(string nome, string valor)
        {

            if (string.IsNullOrEmpty(valor))
            {
                throw new ApplicationException("Deve ser informado um " + nome);
            }
        
        }
    }
}

