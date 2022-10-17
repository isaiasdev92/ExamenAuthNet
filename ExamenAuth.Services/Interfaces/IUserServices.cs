using ExamenAuth.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Application.Interfaces
{
    public interface IUserServices
    {
        UserResponse AddUser(UserRequest request);

        AuthResponse Authentication(AuthRequest request);

        void ChangePassword(ChangePasswordRequest request);
    }
}
