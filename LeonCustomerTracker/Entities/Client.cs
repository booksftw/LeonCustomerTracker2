using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeonCustomerTracker.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string first_name { get; set; }

        public string last_name { get; set; }
        //[Required]
        public DateTime birthday { get; set; }
        public int spending { get; set; }
        public Rank rank { get; set; }
        public string notes { get; set; }
        public DateTime date_created { get; set; }
    }

    public enum Rank
    {
        Normal = 0,
        Good = 1,
        VIP = 2
    }
    
}
