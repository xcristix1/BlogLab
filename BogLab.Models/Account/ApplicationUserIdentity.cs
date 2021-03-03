﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BogLab.Models.Account
{
    class ApplicationUserIdentity
    {
        public int ApplicationUserId { get; set; }
        public string Username { get; set; }
        public string NormalizedUsername { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string Fullname { get; set; }
        public string PasswordHash { get; set; }

    }
}
