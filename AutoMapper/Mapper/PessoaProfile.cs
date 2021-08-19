using AutoMapper;
using AutoMapper.Application.Dto;
using AutoMapper.Model;

namespace AutoMapperApi.Mapper
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<PessoaRequest, PessoaDto>()
                .ForMember(dst => dst.NomeCompleto, map => map.MapFrom(src => $"{src.Nome} {src.Sobrenome}")); ;

            CreateMap<PessoaDto, PessoaRequest>()
                .ForMember(dst => dst.Nome, map => map.MapFrom(src => src.GetNome()))
                .ForMember(dst => dst.Sobrenome, map => map.MapFrom(src => src.GetSobrenome()));
        }
    }
}
