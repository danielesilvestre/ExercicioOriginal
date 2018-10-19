using System;

namespace Model.Model
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Autor { get; set; }        
        public string Titulo { get; set; }
        public TemaLivroModel Tema { get; set; }
        public double Valor { get; set; }
    }
}