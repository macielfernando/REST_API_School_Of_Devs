﻿using SchoolOfDevs.Enum;

namespace SchoolOfDevs.Entities
{
    public class User : BaseEntity
    {

        public int Id { get; set; }

        public string FirestName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public TypeUser TypeUser { get; set; }
    }
}
 