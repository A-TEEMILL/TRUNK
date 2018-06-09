using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameServer.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual List<Score> Scores { get; set; }
    }
}