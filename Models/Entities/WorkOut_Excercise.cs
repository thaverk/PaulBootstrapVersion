using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapProto.Models.Entities
{
    public class WorkOut_Excercise
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Warm_Ups))]
        public int? WarmUpID { get; set; }
        [ForeignKey(nameof(Excercise))]
        public int? ExcerciseID { get; set; }
        [ForeignKey(nameof(Workout))]
        public int? WorkOutID {get; set; }

        public int? week { get; set; }
    }
}
