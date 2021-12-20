using DataAnnotation.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation.Data
{
    [Table("Hayvanlar")]
    public class Hayvan
    {
     
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string Ad { get; set; }
        
        public Cinsiyet Cinsiyet { get; set; }
        
        public bool SahibiVarMi { get; set; }
        
        public DateTime DogumTarihi { get; set; }
        
        public decimal Kutle { get; set; }
        
        public string Tur { get; set; }
        
        public virtual ICollection<Bakici> Bakicilar { get; set; }

        [ForeignKey("Yiyecek")]
        public int? FavoriYiyecekId { get; set; }
        public virtual Yiyecek Yiyecek { get; set; }
    }
}
