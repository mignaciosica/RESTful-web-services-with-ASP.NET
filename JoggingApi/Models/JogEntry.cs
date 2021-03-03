using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoggingApi.Models
{
    public class JogEntry
    {
        public long Id { get; set; }
        private DateTime _date;
        public DateTime Date { get => _date; set => _date = DateTime.Now; }
        public float Distance { get; set; }
        public float Time { get; set; }
        public string Location { get; set; }
    }
}
