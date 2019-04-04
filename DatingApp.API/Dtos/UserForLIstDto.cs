using System;

namespace DatingApp.API.Dtos
{
    public class UserForLIstDto
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Gender{ get; set; }
        public int age { get; set; }
        public string KnownAS { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }

    }
}