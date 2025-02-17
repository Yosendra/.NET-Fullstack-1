﻿using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace GigHub.ViewModels
{
    public class IndexVM
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }
}