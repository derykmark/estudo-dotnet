using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WachList.Models.Mappings
{
    public class MovieMapping 
    {
        public MovieMapping (EntityTypeBuilder<Movie> builder)
        {
            builder
                .ToTable("Movies");

             builder
                .HasKey(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Id)
                .IsRequired()
                .HasMaxLenght(255);
            
            builder
                .Property(m => m.Image)
                .IsRequired(255);
            
            
            builder
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLeght(255);

            
            builder
              .HasOne(m => m.Movies)
              .WithMany(u => u.User)
              .HasForeingKey(u => u.User.Id);
                
        }
    }
}

