using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.InfraEstructure.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            ToTable("Task");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Title)
                .HasMaxLength(80)
                .IsRequired();

            Property(x => x.CreateDate);

            HasRequired(x => x.User);
        }
    }
}
