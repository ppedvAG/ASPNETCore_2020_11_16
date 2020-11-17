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

        [DisplayName("Club Name")]
        [MaxLength(30)]
        public string ClubName { get; set; }

        public DateTime FounderYear { get; set; }

        public int Money { get; set; }

        public int StadiumSize { get; set; }
    }
}
