using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, UserName = "Amrit", Email = "Amrit@gmail.com", PhoneNumber = "7802327566" },
            new User { Id = 2, UserName = "Guri", Email = "Guri@gamil.com", PhoneNumber = "8255678943" },
            new User { Id = 3, UserName = "Riya", Email = "Riya@gmail.com", PhoneNumber = "7888847566" }
        );

        modelBuilder.Entity<Post>().HasData(
            new Post { Id = 1, Title = "First Post", Content = "This is the content of the first post." }
        );
    }
}
