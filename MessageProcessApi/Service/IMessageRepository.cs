using System;
using MessageProcessApi.Models;

namespace MessageProcessApi.Service
{
    public interface IMessageRepository
    {
        public void Add<T>(T newItem) where T : class;
    }
}
