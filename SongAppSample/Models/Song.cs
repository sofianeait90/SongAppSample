using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SongAppSample.Models
{
    public class Song
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public short TrackNumber { get; set; }
        public int VolumeNumber { get; set; }
        public DateTime? DateAddedToCollecton { get; set; }
        public Genre Genre { get; set; }

    }
}