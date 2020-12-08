using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasCards.Models
{
    public class CardModel
    {
        public int Id { get; set; }

        //public Image { get; set; }

        public string Message { get; set; }

        public fonttype Fonttype { get; set; }

        //public Music { get; set; }

        public ICollection<EmailModel> Emails { get; set; }
    }

    public enum fonttype
    {
        Times_New_Roman,
        Comic_Sans,
        IOnlyKnow2FontTypes
    }
}
