using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAcccountService
    {
        Task<User> GetUserByEmail(string email);
    }
}
