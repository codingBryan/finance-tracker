﻿using Finance_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker.Services.UserService
{
    public interface IUserRepository
    {
        Task<User> AddUpdateUser(User user);
    }
}
