using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitleData.Models
{
    public class TitleDetail
    {
        public List<Award> Award { get; set; }
        public Genre Genre { get; set; }
        public OtherName OtherName { get; set; }
        public Participant Participant { get; set; }
        public StoryLine StoryLine { get; set; }
        public TitleGenre TitleGenre { get; set; }
        public TitleParticipant TitleParticipant { get; set; }
    }
}
