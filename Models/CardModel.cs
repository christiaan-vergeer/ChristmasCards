using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasCards.Models
{
    public class CardModel
    {
        public int id { get; set; }

        //public image { get; set; }

        public string message { get; set; }

        public fonttype fonttype { get; set; }

        //public music { get; set; }
    }

    public enum fonttype
    {
        Times_New_Roman,
        Comic_Sans,
        IOnlyKnow2FontTypes
    }
}
