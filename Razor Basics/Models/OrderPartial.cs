using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasics.Models {
    [ModelMetadataType(typeof(OrderMeta))]
    public partial class Order {
    }

    public class OrderMeta {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
