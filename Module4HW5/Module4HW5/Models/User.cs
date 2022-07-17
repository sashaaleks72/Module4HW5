using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Password { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string SurName { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;
           
        public virtual Role? Role { get; set; }
      
        public int RoleId { get; set; }

        public override string ToString()
        {
            return $"UserId: {Id}\nEmail: {Email}\nFirst name: {FirstName}\nSurname: {SurName}\nAge: {Age}";
        }
    }
}
