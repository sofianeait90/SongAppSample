using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SongAppSample.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime RleaseDate { get; set; }
        public DateTime MyProperty { get; set; }
        public short TotalTrack { get; set; }
        public  string ImageLink  { get; set; }

    }
}