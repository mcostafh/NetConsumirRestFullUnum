using System;
using System.Linq;
using AutoMapper;

namespace TDM.SysCRM.AutoMapper
{
    public class AutoMapperConfig 
    {
        
        public static void Configurar()
        {
           /* var profiles = typeof(AutoMapperConfig).Assembly.GetTypes()
                .Where(y => y.BaseType == typeof(Profile))
                .ToList();
            foreach (var profile in profiles)
                Mapper.AddProfile((Profile) Activator.CreateInstance(profile));*/
        }
    }
}