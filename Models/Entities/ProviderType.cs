using System.ComponentModel.DataAnnotations;

namespace BootstrapProto.Models.Entities
{
    public class ProviderType
    {
        [Key]
        public int TypeID{get; set; }
        public string  TypeName { get; set; }
        public string TypeDescription { get; set; }

    }
}
