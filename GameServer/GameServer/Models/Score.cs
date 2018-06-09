using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameServer.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int UserScore { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}