﻿namespace DotNet_Backend.Data.Contracts.Requests
{
    public class LoginRequest
    {
        public string EmailOrUsername { get; set; }
        public string Password { get; set; }
    }
}