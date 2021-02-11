using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
                new Subject { 
                    Id = Constants.SubjectCsharp,
                    Name="C#",
                    Description="Csharp programming language"
                },
                new Subject { 
                    Id = Constants.SubjectDatabase,
                    Name="Database",
                    Description="Sql Server for beginners"
                },
                new Subject { 
                    Id =Constants.SubjectWebapps,
                    Name="Web apps",
                    Description = "Web applications in ASP.NET Core"
                }
                );
        }
    }
}
