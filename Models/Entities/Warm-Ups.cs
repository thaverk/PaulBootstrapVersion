using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapProto.Models.Entities
{
    public class Warm_Ups
    {
        [Key]
        public int WarmUpID { get; set; }
        public string WarmUpName { get; set; }
        public string WarmUpDescription { get; set; }
       
        [ForeignKey(nameof(BodyPart))]
        public int? BodyPartID { get; set; }
        
        public string? Category { get; set; }
    
    }
}



