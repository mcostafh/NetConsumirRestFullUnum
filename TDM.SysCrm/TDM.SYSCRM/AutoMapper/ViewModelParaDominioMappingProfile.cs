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
    public class ViewModelParaDominioMappingProfile : Profile
    {
        
        protected override void Configure()
        {
            Mapper.CreateMap<PotencialExibicaoViewModel, Potencial>();
            Mapper.CreateMap<PotencialViewModel, Potencial>();

            Mapper.CreateMap<StatusAcionamentoExibicaoViewModel, Potencial>();
            Mapper.CreateMap<StatusAcionamentoViewModel, Potencial>();

        }
    }
}