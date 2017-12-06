using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2TLN.Models
{
    public class Endereco
    {

        public int EnderecoId { get; set; }
        public String Logradouro { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public String Numero { get; set; }
        public Socio Socio { get; set; }


    }
}