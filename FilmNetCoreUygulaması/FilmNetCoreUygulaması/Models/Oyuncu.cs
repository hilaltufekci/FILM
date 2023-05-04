using System.ComponentModel.DataAnnotations;

namespace FilmNetCoreUygulaması.Models
{
    public class Oyuncu
    {
        [Key]
        public int OyuncuNo { get; set; }

        [Required]
        [StringLength(30)]
        public string OyuncuAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string OyuncuSoyadi { get; set; }

        [Required]
        [Range(15, 70, ErrorMessage = "Bu yaş aralığı dışında kayıt yapılamamaktadır.")]
        public int OyuncuYas { get; set; }

        public int OynadigiFilmSayisi { get; set; }
    }
}
