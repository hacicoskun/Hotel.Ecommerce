using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecoomerce.DAL.Concrete
{
    [Table("AnasayfaSlider")]
    public class AnasayfaSlider:BaseEntity
    {
        public string Isım { get; set; } //Path

        public int Düzen { get; set; }
        public string Link { get; set; } = "";
        public string Hedef { get; set; }
        public DateTime SliderBaslangicTarihi { get; set; }
        public DateTime SliderBitisTarihi { get; set; }
        public string Tip { get; set; }

    }
}
