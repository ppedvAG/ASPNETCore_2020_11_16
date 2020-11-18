using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageWithEF.Models
{
    public class FootballClub
    {
        public int Id { get; set; }

        [DisplayName("Club Name")] // <- Data Annotation 
        [MaxLength(30)]
        public string ClubName { get; set; }

        [MinLength(3, ErrorMessage = "Moment bitte Stadionname eingeben")]
        public string StadiumName { get; set; }

        public DateTime FounderYear { get; set; }

        public int Money { get; set; }

        [Range(10000, 80000)]
        public int StadiumSize { get; set; }
    }
}

//DataAnnotation helfen in der UI - Formularen, dass der Datensatz (FootballClub) valide ausgefüllt wird,

// Richtung Datanbank in Verbindung mit CodeFirst, kann man die Tabellenspalten somit charakterisieren 
