using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDM.SysCRM.Dominio;
using TDM.SysCRM.ViewModels.StatusAcionamento;
using TDM.SysCRM.ViewModels.Potencial;

namespace TDM.SysCRM.AutoMapper
{
    public class DominioParaViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Potencial, PotencialExibicaoViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} ", src.Nome)
                     );
                });

            Mapper.CreateMap<Potencial, PotencialViewModel>();


            Mapper.CreateMap<StatusAcionamento, StatusAcionamentoExibicaoViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} ", src.Nome)
                     );
                });

            Mapper.CreateMap<StatusAcionamento, StatusAcionamentoViewModel>();


        }

    }
}