using AutoMapper;

namespace Caminhoneiro.MapViewModelDTO
{
    public class ViewModelDTOConfig
    {
        public static void ResgistrarMap()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelDTOProfile>();
            });
        }
    }
}
