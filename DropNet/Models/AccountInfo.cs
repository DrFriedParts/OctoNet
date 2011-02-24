﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DropNet.Models
{
    public class AccountInfo
    {
        public string referral_link { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string display_name { get; set; }
        public QuotaInfo quota_info { get; set; }
        public long uid { get; set; }
    }

    public class QuotaInfo
    {
        public long shared { get; set; }
        public long quota { get; set; }
        public long normal { get; set; }
    }
}
