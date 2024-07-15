using System.ComponentModel.DataAnnotations;

namespace BootstrapProto.Models.Entities
{
    public class Provider
    {
        [Key]
        public int SPId { get; set; }
        public string SPName { get; set; }
        public string SPEmail { get; set; }
        public string SPPassword { get; set; } 
        public int SPType { get; set; }

    
    }
}
