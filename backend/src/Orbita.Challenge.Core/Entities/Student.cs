using System;
using System.Collections.Generic;
using System.Text;

namespace Orbita.Challenge.Core.Entities
{
    public class Student
    {
        public Guid Ra { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
