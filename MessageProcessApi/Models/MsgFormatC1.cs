using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageProcessApi.Models
{
    public class MsgFormatC1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MsgFormatC1Id { get; set; }
        public string MsgText { get; set; }
        public string MsgTime { get; set; }
        public int MsgFormatCId { get; set; }
        public MsgFormatC MsgFormatC { get; set; }
    }
}
