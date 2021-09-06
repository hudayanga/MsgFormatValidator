using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageProcessApi.Models
{
    public class MsgFormatB1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MsgFormatB1Id { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public int MsgFormatBId { get; set; }
        public MsgFormatB MsgFormatB { get; set; }
    }
}
