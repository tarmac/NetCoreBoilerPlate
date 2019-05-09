using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreBoilerplate.Entities.Models
{
    [Table("MessageType")]
    public class MessageType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MessageTypeId")]
        public long Id { get; set; }

        public string Name { get; set; }
    }
}