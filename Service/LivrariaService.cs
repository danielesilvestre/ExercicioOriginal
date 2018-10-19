using Business;
using Business.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class LivrariaService
    {
        public List<LivroDTO> ObterLivros()
        {
            LivrariaBusiness business = new LivrariaBusiness();
            return business.ObterLivros();
        }

        public List<LivroDTO> ObterAutores()
        {
            LivrariaBusiness business = new LivrariaBusiness();
            return business.ObterAutores();
        }

        public List<LivroDTO> ObterTitulos()
        {
            LivrariaBusiness business = new LivrariaBusiness();
            return business.ObterTitulos();
        }

        public List<TemaLivroDTO> ObterTemas()
        {
            LivrariaBusiness business = new LivrariaBusiness();
            return business.ObterTemas();
        }

        public List<LivroDTO> ObterLivrosPorTema(string tema)
        {
            LivrariaBusiness business = new LivrariaBusiness();
            return business.ObterLivrosPorTema(tema);
        }

        public List<LivroDTO> ObterLivrosPorAutor(string autor)
        {
            LivrariaBusiness bussiness = new LivrariaBusiness();
            return bussiness.ObterLivrosPorAutor(autor);
        }
  }
}
