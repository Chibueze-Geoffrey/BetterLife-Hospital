using AutoMapper;

namespace BetterLifeHospital.Services.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Entities.Patient, Dtos.PatientDto>();
            CreateMap<Dtos.PatientCreated, Entities.Patient>();
            //eateMap<Dtos.PatientCreatedDto,ies.Article>();
            //CreateMap<Dtos.ArticleUpdateDto, Entities.Article>();
            //CreateMap<Entities.Article, Dtos.ArticleUpdateDto>();
        }
    }
}
