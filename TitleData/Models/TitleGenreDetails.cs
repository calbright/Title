using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitleData.Models
{
    public class TitleGenreDetails
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
