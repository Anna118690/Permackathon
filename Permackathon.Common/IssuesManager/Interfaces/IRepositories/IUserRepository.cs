﻿using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.IssuesManager.Interfaces.IRepositories
{
    public interface IUserRepository : IRepository<UserTO, int>
    {
    }
}
