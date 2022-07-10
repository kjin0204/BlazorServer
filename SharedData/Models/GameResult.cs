using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedData.Models
{
    public class GameResult
    {
        public int Id { get; set; } //식별자
        public int UserId { get; set; }
        public string userName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
