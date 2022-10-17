// See https://aka.ms/new-console-template for more information
using ExamenAuth.Application.Models;
using ExamenAuth.Infraestructure.Services;

//Console.WriteLine("Hello, World!");


var services = new UserServices();

var userNew = new UserRequest {
    Email = "user@mail.com",
    LastName = "Smith",
    Name = "John",
    Password = "1234"
};


Console.WriteLine($"User create with ID: {services.AddUser(userNew).UserId}");



var loginRequest = new AuthRequest 
{
    Email = "user@mail.com",
    Password = "1234"
};

var response = services.Authentication(loginRequest);


Console.WriteLine($"El token es: {response.Token}");
