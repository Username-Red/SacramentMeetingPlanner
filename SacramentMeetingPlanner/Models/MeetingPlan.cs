using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SacramentMeetingPlanner.Models
{
    public class MeetingPlan
    {
        //attributes
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        public string? ConductingLeader { get; set; }

        public string? OpeningHymn { get; set; }

        public string? SacramentHymn { get; set; }

        public string? ClosingingHymn { get; set; }

        public string? IntermediateHymn { get; set; }

        public string? OpeningPrayer { get; set; }

        public string? ClosingPrayer { get; set; }

        public string? SpeakerSubjects { get; set; }


        //constructors

        //methods

    }
}
