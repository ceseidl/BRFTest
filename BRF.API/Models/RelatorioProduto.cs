using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore;

namespace BRF.API.Models
{
    
    public partial class RelatorioProduto
    {

        public string NomeFornecedor{ get; set; }
        public string NomeProduto { get; set; }
        


    }
}
