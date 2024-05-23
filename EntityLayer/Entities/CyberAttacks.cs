using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class CyberAttacks
    {
        public int Id { get; set; }

        [DisplayName("Siber Saldırı İsmi")]
        public string attackName { get; set; }

        [DisplayName("Siber Saldırı Detay")]
        public string attackDetails { get; set; }

        public virtual WorldCountries worldCountry { get; set; }
    }
}
