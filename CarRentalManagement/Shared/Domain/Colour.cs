using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
	public class Colour : BaseDomainModel
	{
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name is Too short")]
        public string? Name { get; set; }
    }
}
