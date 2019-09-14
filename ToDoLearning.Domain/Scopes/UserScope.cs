using ToDoLearning.SharedKarnel.Validations;

namespace ToDoLearning.Domain.Scopes
{
    public static class UserScope
    {
        public static void ValidUserName(string name)
        {
            AssertionConcern.IsValid(
                AssertionConcern.AssertLength(name, 5, 100, "O nome do usuário deve ser maior ou igual a 5 e menor ou igual a 100 caracteres!")
            );
        }

        public static void ValidEmail(string email)
        {
            AssertionConcern.IsValid(
                AssertionConcern.AssertEmailIsValid(email, "O Email não está no formato adequado!")
            );
        }
    }
}
