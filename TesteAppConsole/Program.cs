using System;
using ToDoLearning.Domain.Entities;
using ToDoLearning.InfraEstructure.Repositories;

namespace TesteAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Alex Marden", "amarden.nascimento@gmail.com");

            UserRepository repository = new UserRepository();
            repository.Create(user);

            Console.WriteLine("Usuario cadastrado com sucesso!");

            Console.ReadKey();
        }
    }
}
