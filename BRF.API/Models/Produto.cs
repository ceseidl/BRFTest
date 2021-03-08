using System;
using System.Collections.Generic;

namespace BRF.API.Models
{
    public partial class Produto
    {
        public Guid Id { get; set; }
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Deleted { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
