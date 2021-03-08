using System;
using System.Collections.Generic;

namespace BRF.API.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produto = new HashSet<Produto>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
