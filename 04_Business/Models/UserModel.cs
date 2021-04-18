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
    public class UserModel : ObligatoryProperities
    {
        [Required]
        [DisplayName("Kullanıcı Adı:")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Parola:")]
        public string Password { get; set; }
        [Required]
        
        public int RoleId { get; set; }
        [Required]
        [DisplayName("Parolayı Tekrarla:")]
        public string PasswordAgain { get; set; }
        [Required]
        
        public int FactoryId { get; set; }

        [Required]
        [DisplayName("Mail Adresi:")]
        public  string Mail { get; set; }

        [Required]
        [DisplayName("Mail Adresini tekrarla:")]
        public string MailAgain { get; set; }
    }
}
