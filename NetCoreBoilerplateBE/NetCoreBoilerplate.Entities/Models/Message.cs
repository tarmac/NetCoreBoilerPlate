using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreBoilerplate.Entities.Models
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MessageId { get; set; }

        public long MessageTypeId { get; set; }
        public long UserFromId { get; set; }
        public long UserToId { get; set; }

        [StringLength(100, ErrorMessage = "Comment can not be longer than 100 characters")]
        public string Comment { get; set; }

        public DateTime DtMessage { get; set; }
        public DateTime DtCreate { get; set; }

        public User UserTo { get; set; }
        public User UserFrom { get; set; }
        public MessageType Type { get; set; }
    }
}