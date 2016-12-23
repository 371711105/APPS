using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo.Models
{
    public interface IUser
    {
        List<UserInfo> GetUsers();
    }
}
