using System;

namespace AutoMapper.Model
{
    public class PessoaRequest
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
