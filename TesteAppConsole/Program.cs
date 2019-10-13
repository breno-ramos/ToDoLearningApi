using System;
using ToDoLearning.Domain.Entities;
using ToDoLearning.InfraEstructure.Repositories;

namespace TesteAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Marllon Ramos", "87marllon@gmail.com");

            UserRepository repository = new UserRepository();
            repository.Create(user);

            Task task = new Task(user, "Nadar");
            TaskRepository taskRepository = new TaskRepository();
            taskRepository.Create(task);

            Console.WriteLine("Tarefa cadastrado com sucesso!");

            Console.ReadKey();
        }
    }
}
