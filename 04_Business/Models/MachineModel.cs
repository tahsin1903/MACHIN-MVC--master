using _02_DataEntities.Entities;
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
    public class MachineModel : ObligatoryProperities
    {
        [Required]
        [DisplayName("Makine İsmi:")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Seri/Kayıt Numarası:")]
        public int SeriNO { get; set; }
        [Required]
        [DisplayName("Modeli:")]
        public string Model { get; set; }
        [Required]
        [DisplayName("Detay:")]
        public string Detail { get; set; }
        [Required]
        [DisplayName("Bölüm Adı")]
        public int SectionId { get; set; }

        [DisplayName("Bölüm Adı")]
        public string SectionName { get; set; }
    }
}
