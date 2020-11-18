using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEF.Models
{
    public class Artikel
    {
        public Guid Id { get; set; }
        public string Titel { get; set; }

        [MinLength(20, ErrorMessage = "Bitte einen Text eingeben mit mind. 20 Zeichen")]
        public string Content { get; set; }

        public DateTime PublishedAt { get; set; }
    }
}
