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
        public string SliderResim { get; set; }
        public string SliderTarget { get; set; }
        public string SliderLink { get; set; }
        public DateTime SliderBaslangicTarihi { get; set; }
        public DateTime SliderBitisTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
