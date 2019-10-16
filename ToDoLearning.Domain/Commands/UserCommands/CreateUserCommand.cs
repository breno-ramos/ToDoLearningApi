namespace ToDoLearning.Domain.Commands.UserCommands
{
    public class CreateUserCommand
    {
        public CreateUserCommand(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
