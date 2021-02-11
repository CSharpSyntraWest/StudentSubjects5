using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasData(
                new StudentSubject
                {
                    StudentId = Constants.StudentJos,//Jos
                    SubjectId = Constants.SubjectCsharp//C#
                },
                new StudentSubject
                {
                    StudentId = Constants.StudentJos,//Jos
                    SubjectId = Constants.SubjectDatabase // Database
                },
                new StudentSubject {
                    StudentId= Constants.StudentJoke, //Joke
                    SubjectId = Constants.SubjectCsharp//C#
                },
                new StudentSubject {
                    StudentId = Constants.StudentJoke, //Joke
                    SubjectId = Constants.SubjectWebapps//Web apps
                }
                ); 
        }
    }
}
