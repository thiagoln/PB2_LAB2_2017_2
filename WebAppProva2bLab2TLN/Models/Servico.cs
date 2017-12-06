using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2TLN.Models
{
    public class Servico
    {

        public int ServicoId { get; set; }
        public DateTime Descricao { get; set; }
        public List<Clube> Clubes { get; set; }


    }
}