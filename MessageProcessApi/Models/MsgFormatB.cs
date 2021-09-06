using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageProcessApi.Models
{
    public class MsgFormatB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MsgFormatBId { get; set; }
        public string Timestamp { get; set; }
        public MsgFormatB1 message { get; set; }
        public MsgFormatB2 source { get; set; }

    }
}
