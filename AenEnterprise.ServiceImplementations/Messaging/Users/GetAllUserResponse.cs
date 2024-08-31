﻿using AenEnterprise.ServiceImplementations.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AenEnterprise.ServiceImplementations.Messaging.Users
{
    public class GetAllUserResponse
    {
       public IEnumerable<UserView> users { get; set; }
       public UserView user { get; set; }
    }
}
