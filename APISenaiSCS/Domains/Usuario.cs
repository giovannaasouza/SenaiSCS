using System;
using System.Collections.Generic;

#nullable disable

namespace APISenaiSCS.Domains
{
    public partial class usuario
    {
        public int id { get; set; }
        public string NIF { get; set; }
        public string senha { get; set; }
    }
}
