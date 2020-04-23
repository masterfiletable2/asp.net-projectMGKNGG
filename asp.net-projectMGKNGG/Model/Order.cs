using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_projectMGKNGG.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }

        public string OpisZamowienia { get; set; }

        public string Data { get; set; }
    }
}
