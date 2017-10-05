using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metada.Builders;

namespace WachList.Models.Mappings
{
    public class UserMapping
    {
        public UserMapping (EntityTypeBuilder<User> builder)
        {
            builder
                .Totable("Users");

            builder
                .HasKey(u => u.ID)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.Id)
                .IsRequired()
                .HasMaxLeght(200);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLeght(255);

            builder
                .HasMany(u => u.Movies)
                .WithOne(m => m.User)
                .HasForeingKey(m => m.UserId);
        }
    }
}