﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2TLN.Models
{
    public class Socio
    {

        public int SocioId { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public Clube Clube { get; set; }
        public Endereco Endereco { get; set; }


    }
}