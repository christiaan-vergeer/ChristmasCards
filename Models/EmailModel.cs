using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasCards.Models
{
    public class EmailModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public EmailModel Card { get; set; }
    }
}
