using AppCore.DataAccess.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Business.Models
{
    public class FactoryModel : ObligatoryProperities
    {
        [Required]
        [DisplayName("Fabrika İsmi:")]
        public string Name { get; set; }
    }
}
