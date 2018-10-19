using System;

namespace Business.DTO
{
    public class LivroDTO
    {
        const double Desconto = 0.10;
        private double ValorDesconto;

        public int Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public TemaLivroDTO Tema { get; set; }
        public double Valor
        {
            get { return ValorDesconto - Desconto;}
            set { ValorDesconto = value; }
        }
    }
}
