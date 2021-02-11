using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = Constants.StudentJos,
                    FirstName = "Jos",
                    LastName = "De Klos",
                    BirthDate = new DateTime(1947,6,7) //DateTime.Now.AddYears(-45)
                },
                new Student
                {
                    Id = Constants.StudentJoke,
                    FirstName = "Joke",
                    LastName = "De Klos",
                    BirthDate = new DateTime(1927, 10, 1) // DateTime.Now.AddYears(-25)
                },
                new Student
                {
                    Id = Constants.StudentJan,
                    FirstName = "Jan",
                    LastName = "Jansens",
                    BirthDate = new DateTime(2001, 5, 14)//DateTime.Now.AddYears(-19)
                });
        }
    }
}
