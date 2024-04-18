using AutoMapper;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CurrencyPair, CurrencyPairDto>();
            CreateMap<CurrencyPairDto, CurrencyPair>();
            CreateMap<CreateCurrencyPairDto, CurrencyPair>();
        
            CreateMap<Authentication, AuthenticationDto>();
            CreateMap<AuthenticationDto, Authentication>();
            CreateMap<CreateAuthenticationDto, Authentication>();
        
            CreateMap<HistoryData, HistoryDataDto>();
            CreateMap<HistoryDataDto, HistoryData>();
            CreateMap<CreateHistoryDataDto, HistoryData>();
        
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<CreateUserDto, User>();

            CreateMap<Model, ModelDto>();
            CreateMap<ModelDto, Model>();
            CreateMap<CreateModelDto, Model>();

            CreateMap<Subscription, SubscriptionDto>();
            CreateMap<SubscriptionDto, Subscription>();
            CreateMap<CreateSubscriptionDto, Subscription>();
        
            CreateMap<Verification, VerificationDto>();
            CreateMap<VerificationDto, Verification>();
            CreateMap<CreateVerificationDto, Verification>();

        }
    }
}