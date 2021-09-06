using System;
using Microsoft.EntityFrameworkCore;

namespace MessageProcessApi.Models
{
    public class MessageDbContext : DbContext
    {
        public DbSet<MsgFormatA> MsgFormatA { get; set; }
        public DbSet<MsgFormatB> MsgFormatB { get; set; }
        public DbSet<MsgFormatC> MsgFormatC { get; set; }

        public MessageDbContext(DbContextOptions<MessageDbContext> options): base(options)
        {

        }
    }
}
