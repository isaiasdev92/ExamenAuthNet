using ExamenAuth.Application.Interfaces;
using ExamenAuth.Application.Models;
using ExamenAuth.Infraestructure.Data;
using ExamenAuth.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Infraestructure.Services
{
    public class UserServices : IUserServices
    {
        

        public UserServices()
        {
            
        }

        public UserResponse AddUser(UserRequest request)
        {
            var response = new UserResponse();
            try
            {
                if (request is null)
                {
                    return response;
                }

                if (string.IsNullOrEmpty(request.Name))
                {
                    return response;
                }

                if (string.IsNullOrEmpty(request.Email))
                {
                    return response;
                }

                if (string.IsNullOrEmpty(request.LastName))
                {
                    return response;
                }

                if (string.IsNullOrEmpty(request.Password))
                {
                    return response;
                }

                var users = ContextRepository.DataUsersDb.ToList();

                var existUser = users.Exists(a => a.Email == request.Email);
                if (true)
                {
                    return response;

                }

                var idAdd = ContextRepository.DataUsersDb.Length + 1;

                var userNew = new DataUser
                {
                    Email = request.Email,
                    Id = idAdd,
                    LastName = request.LastName,
                    Name = request.Name,
                    Password = request.Password
                };

                users.Add(userNew);

                ContextRepository.DataUsersDb = users.ToArray();

                response.Status = true;


            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in {ex.Message}");
            }

            return response;
        }

        public AuthResponse Authentication(AuthRequest request)
        {
            var response = new AuthResponse
            {
                Status = false
            };

            try
            {

                var userFind = ContextRepository.DataUsersDb.FirstOrDefault(a => a.Email == request.Email && a.Password == a.Password);

                if (userFind is null)
                {
                    return response;
                }

                response.Token = Guid.NewGuid().ToString();

                foreach (var item in ContextRepository.DataUsersDb)
                {
                    if (item.Email == request.Email)
                    {
                        item.TokenActived = response.Token;
                    }
                }
                
            }
            catch (Exception)
            {

                response.Status = false;
            }
                return response;
        }

        public void ChangePassword(ChangePasswordRequest request)
        {
            if (request is null)
            {
                return;
            }

            if (string.IsNullOrEmpty(request.PasswordNew))
            {
                return;
            }

            if (string.IsNullOrEmpty(request.PasswordBefore))
            {
                return;
            }

            var users = ContextRepository.DataUsersDb.ToList();

            var userFind = users.SingleOrDefault(a => a.Id == request.UserId);

            
        }
    }
}
