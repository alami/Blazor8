using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Tag
    {
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
