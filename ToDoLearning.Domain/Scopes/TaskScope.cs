using ToDoLearning.SharedKarnel.Validations;

namespace ToDoLearning.Domain.Scopes
{
    public static class TaskScope
    {
        public static void ValidTaskTitle( string title)
        {            
                AssertionConcern.IsValid(
                    AssertionConcern.AssertLength(title, 5, 30, "O título da tarefa deve ser maior ou igual a 5 e menor ou igual a 100 caracteres!")
                );         
        }
    }
}
