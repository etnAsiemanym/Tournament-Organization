using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tournament_Organization.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    FirstName = "Mark",
                    LastName = "Miens"
                },
                new User
                {
                    FirstName = "Anna",
                    LastName = "Simmons"
                }
            );
        }
    }
}
