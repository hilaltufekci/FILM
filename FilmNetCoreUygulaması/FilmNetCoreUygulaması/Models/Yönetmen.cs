using System.ComponentModel.DataAnnotations;

namespace FilmNetCoreUygulaması.Models
{
    public class Yönetmen
    {

        [Key]
        public int YönetmenNo { get; set; }

        [Required]
        [StringLength(30)]
        public string YönetmenAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string YönetmenSoyadi { get; set; }

        [Required]
        [Range(20, 55, ErrorMessage = "Bu yaş aralığı dışında kayıt yapılamamaktadır.")]
        public int Yas { get; set; }
        public int FilmSayisi { get; set; }
    }
}
