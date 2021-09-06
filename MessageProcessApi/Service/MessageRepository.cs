using System;
using MessageProcessApi.Models;

namespace MessageProcessApi.Service
{
    public class MessageRepository: IMessageRepository
    {
        private readonly MessageDbContext _db;
        public MessageRepository(MessageDbContext db)
        {
            _db = db;
        }

        public void Add<T>(T newItem) where T : class
        {
            _db.Set<T>().Add(newItem);
            _db.SaveChanges();
        }

    }
}
