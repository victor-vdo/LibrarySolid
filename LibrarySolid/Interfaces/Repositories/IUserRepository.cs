﻿using LibrarySolid.Models;

namespace LibrarySolid.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetById(Guid id);
        List<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(Guid id);
    }
}