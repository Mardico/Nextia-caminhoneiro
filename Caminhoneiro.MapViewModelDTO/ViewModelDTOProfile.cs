using AutoMapper;
using Caminhoneiro.DTO.Apolice;
using Caminhoneiro.DTO.Cliente;
using Caminhoneiro.DTO.Shared;
using Caminhoneiro.DTO.Usuario;
using Caminhoneiro.ViewModel.Apolice;
using Caminhoneiro.ViewModel.Cliente;
using Caminhoneiro.ViewModel.Shared;
using Caminhoneiro.ViewModel.Usuario;

namespace Caminhoneiro.MapViewModelDTO
{
    class ViewModelDTOProfile : Profile
    {
        public ViewModelDTOProfile()
        {

            //Dados da Apolice
            CreateMap<ApoliceDadosDependenteViewModel, ApoliceDadosDependenteDTO>().ReverseMap();
            CreateMap<ApoliceDadosPagamentoViewModel, ApoliceDadosPagamentoDTO>().ReverseMap();
            CreateMap<ApoliceDadosProdutoViewModel, ApoliceDadosProdutoDTO>().ReverseMap();
            CreateMap<ApoliceDadosVeiculoViewModel, ApoliceDadosVeiculoDTO>().ReverseMap();
            //CreateMap<ApoliceViewModel, ApoliceDTO>().ReverseMap();

            //Dados do Cliente
            CreateMap<ClienteViewModel, ClienteDTO>().ReverseMap();

            //Dados do Usuario
            CreateMap<UsuarioViewModel, UsuarioDTO>().ReverseMap();
            CreateMap<AlteraSenhaViewModel, AlteraSenhaDTO>().ReverseMap();
            CreateMap <FiltroLoginViewModel,FiltroLoginDTO>().ReverseMap();

            //Classes de Apoio
            CreateMap<FiltroGenericoViewModel, FiltroGenericoDTO>().ReverseMap();
            CreateMap(typeof(RetornoGenericoDTO<>), typeof(RetornoGenericoViewModel<>)).ReverseMap();
            CreateMap<TabelaApoioViewModel, TabelaApoioDTO>().ReverseMap();
        }
    }
}
