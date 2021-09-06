using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageProcessApi.Models
{
    public class MsgFormatC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string msisdn { get; set; }
        public MsgFormatC1 message { get; set; }
    }
}
