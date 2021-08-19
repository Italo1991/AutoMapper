using AutoMapper.Application.Dto;
using AutoMapper.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly List<PessoaDto> pessoaDtos = new List<PessoaDto>();
        private readonly IMapper _mapper;

        public PessoaController(IMapper mapper)
        {
            _mapper = mapper;

            pessoaDtos.Add(new PessoaDto() { Codigo = 1, DataCriacao = DateTime.Now, Idade = 12, NomeCompleto = "Rodrigo Albert" });
            pessoaDtos.Add(new PessoaDto() { Codigo = 2, DataCriacao = DateTime.Now, Idade = 14, NomeCompleto = "Italo Guilher" });
            pessoaDtos.Add(new PessoaDto() { Codigo = 3, DataCriacao = DateTime.Now, Idade = 18, NomeCompleto = "Carlos Mazora" });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var mapped = _mapper.Map<List<PessoaRequest>>(pessoaDtos);
            return Ok(mapped);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PessoaRequest request)
        {
            var mapped = _mapper.Map<PessoaDto>(request);
            return Ok(mapped);
        }
    }
}
