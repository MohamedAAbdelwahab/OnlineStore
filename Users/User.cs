﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;

namespace OnlineStore
{
    public abstract class User
    {
        public UserData Data;
        public handler hand;
        public abstract void ConnectPage(UserData data,handler hand);
    }
}