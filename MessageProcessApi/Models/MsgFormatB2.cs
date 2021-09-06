using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageProcessApi.Models
{
    public class MsgFormatB2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MsgFormatB2Id { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public int MsgFormatBId { get; set; }
        public MsgFormatB MsgFormatB { get; set; }
    }
}
