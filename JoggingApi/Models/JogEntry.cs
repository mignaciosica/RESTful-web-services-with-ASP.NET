using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoggingApi.Models
{
    public class JogEntry
    {
        public long Id { get; set; }

        //private DateTime _date;
        //public DateTime Date { get => _date; private set => _date = DateTime.Now; }
        public DateTime Date { get; set; }
        public float Distance { get; set; }
        public float Time { get; set; }
        public string Location { get; set; }
    }
}
