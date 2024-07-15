using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapProto.Models.Entities
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }
        
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        
        public string WorkoutName { get; set; }
        public string WorkoutDescription { get; set; }
    
    }
}
