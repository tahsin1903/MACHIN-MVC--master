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
    public class HatırlatıcıModel : ObligatoryProperities
    {
        [Required]
        [DisplayName("Konu Başlığı:")]
        public string Name { get; set; }

        [MaxLength(200)]
        [DisplayName("Detay:")]
        public string Details { get; set; }

        [Required]
        [DisplayName("Tarih:")]
        public DateTime DateTime { get; set; }

        [Required]

        public int MachineId { get; set; }

        [Required]
        [DisplayName("Alıcı Mail:")]
        public string To { get; set; }

        [Required]
        [DisplayName("Gönderen Mail:")]
        public string From { get; set; }

        [Required]
        [DisplayName("Gönderen Mail Şifresi:")]
        public string GmailPassword { get; set; }

        [Required]
        [DisplayName("Makine:")]
        public string MachineName { get; set; }
    }
}
