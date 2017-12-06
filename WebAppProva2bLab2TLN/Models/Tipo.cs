using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2TLN.Models
{
    public class Tipo
    {

        public int TipoId { get; set; }
        public String Descricao { get; set; }
        public List<Clube> Clubes { get; set; }



    }
}