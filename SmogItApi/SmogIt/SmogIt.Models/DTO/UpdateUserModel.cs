﻿namespace SmogIt.Models.DTO
{
    public class UpdateUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public bool Active { get; set; }
    }
}
