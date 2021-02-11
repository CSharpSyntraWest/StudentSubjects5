using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public static class Constants
    {
        public static readonly Guid SubjectCsharp = new Guid("80abbca8-664d-4b20-b5de-024705497d4a");
        public static readonly Guid SubjectDatabase = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a");
        public static readonly Guid SubjectWebapps = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811");

        public static readonly Guid StudentJos = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870");
        public static readonly Guid StudentJoke = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3");
        public static readonly Guid StudentJan = Guid.NewGuid();

        public static readonly Guid CourseFrontEndDev = Guid.NewGuid();
        public static readonly Guid CourseNetDeveloper = Guid.NewGuid();

    }
}
