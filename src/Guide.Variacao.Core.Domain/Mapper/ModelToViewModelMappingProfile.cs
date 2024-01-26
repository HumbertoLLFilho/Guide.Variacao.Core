using Guide.Variacao.Core.Domain.ViewModels;
using Guide.Variacao.Core.Domain.Models;
using AutoMapper;

namespace Guide.Variacao.Core.Domain.Mapper
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public ModelToViewModelMappingProfile()
        {
            CreateMap<BaseModel, BaseViewModel>();

            CreateMap<Stock, StockViewModel>()
                .ForMember(viewModel => viewModel.AuctionsViewModel, conf => conf.MapFrom(value => value.Auctions))
                .ForMember(viewModel => viewModel.TradingPeriodsViewModel, conf => conf.MapFrom(value => value.TradingPeriods));

            CreateMap<Auction, AuctionViewModel>();

            CreateMap<TradingPeriod, TradingPeriodViewModel>();
        }
    }
}
