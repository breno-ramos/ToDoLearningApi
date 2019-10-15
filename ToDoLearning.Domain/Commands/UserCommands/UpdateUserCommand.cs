namespace ToDoLearning.Domain.Commands.UserCommands
{
    public class UpdateUserCommand
    {
        public UpdateUserCommand(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
