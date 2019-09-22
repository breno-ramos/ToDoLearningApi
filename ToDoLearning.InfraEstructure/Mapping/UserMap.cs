using System.Data.Entity.ModelConfiguration;
using ToDoLearning.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoLearning.InfraEstructure.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(x => x.Tasks);
        }
    }
}
