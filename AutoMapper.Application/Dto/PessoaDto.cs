using System;
using System.Linq;

namespace AutoMapper.Application.Dto
{
    public class PessoaDto
    {
        public int Codigo { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public DateTime DataCriacao { get; set; }

        public string GetNome()
        {
            return NomeCompleto.Split(' ').FirstOrDefault();
        }

        public string GetSobrenome()
        {
            return NomeCompleto.Split(' ').LastOrDefault();
        }
    }
}
