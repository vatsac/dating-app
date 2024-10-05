using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Model;


namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        
        public AutoMapperProfiles()
        {
            CreateMap<Users, UserForListDto>()
              .ForMember(dest => dest.PhotoUrl, opt => 
              opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.IsMain).Url))
              .ForMember(dest => dest.Age, opt => 
              opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Users, UserForDetailedDto>()
              .ForMember(dest => dest.PhotoUrl, opt => 
              opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.IsMain).Url))
               .ForMember(dest => dest.Age, opt => 
               opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, Users>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<UserForRegisterDto, Users>();
            CreateMap<MessageForCreationDto, Message>().ReverseMap();
            CreateMap<Message, MessageToReturnDto>()
            .ForMember(m => m.SenderPhotoUrl, opt => opt.MapFrom(u => u.Sender.Photo.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(m => m.RecipientPhotoUrl, opt => opt.MapFrom(u => u.Recipient.Photo.FirstOrDefault(p => p.IsMain).Url));
        }
    }
}