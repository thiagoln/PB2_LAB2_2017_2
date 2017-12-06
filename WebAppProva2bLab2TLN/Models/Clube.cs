using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2TLN.Models
{
    public class Clube
    {

        public int ClubeId { get; set; }
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }
        public String Descricao { get; set; }
        public List<Socio> Socios { get; set; }
        public List<Servico> Servicos { get; set; }
        public Tipo Tipo { get; set; }


        
    }
}