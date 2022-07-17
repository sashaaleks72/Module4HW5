﻿namespace WorkingWithDB.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual List<User>? Users { get; set; }
    }
}
