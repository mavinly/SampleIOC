using SampleIOC.Models;
using System.Collections.Generic;

namespace SampleIOC.Controllers
{
    public interface IUserRepository
    {
        List<UserModel> GetAll();
    }
}