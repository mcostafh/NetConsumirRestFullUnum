using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.SysCRM.Dominio
{
    public class Concessionaria : Entidade
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public long LimiteCredVeiculo { get; set; }
        public long LimiteCredPeca { get; set; }
    }
}

        
