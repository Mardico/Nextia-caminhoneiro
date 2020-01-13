using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.ViewModel;

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
            CreateMap<ApoliceViewModel, ApoliceDTO>().ReverseMap();
            CreateMap<ApoliceKitProdutoViewModel, ApoliceKitProdutoDTO>().ReverseMap();

            //Dados do Cliente
            CreateMap<ClienteViewModel, ClienteDTO>().ReverseMap();
            CreateMap<ClienteApoliceViewModel, ClienteDTO>().ReverseMap();

            //Dados do Usuario
            CreateMap<UsuarioViewModel, UsuarioDTO>().ReverseMap();
            CreateMap<VinculoViewModel, VinculoDTO>().ReverseMap();
            CreateMap<AlteraSenhaViewModel, AlteraSenhaDTO>().ReverseMap();
            CreateMap <FiltroLoginViewModel,FiltroLoginDTO>().ReverseMap();

            //Produto
            CreateMap<ProdutoViewModel, ProdutoDTO>().ReverseMap();

            //Classes de Apoio
            CreateMap<FiltroGenericoViewModel, FiltroGenericoDTO>().ReverseMap();
            CreateMap(typeof(RetornoGenericoDTO<>), typeof(RetornoGenericoViewModel<>)).ReverseMap();
            CreateMap<TabelaApoioViewModel, TabelaApoioDTO>().ReverseMap();
        }
    }
}
