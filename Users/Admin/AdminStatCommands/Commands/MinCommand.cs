﻿using OnlineStore.Users.Admin.AdminStatCommands.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Commands
{
    public class MinCommand : ICommand // COMMAND
    {
        private IReceiver cmds;

        public MinCommand(IReceiver cmds)
        {
            this.cmds = cmds;
        }

        public String Execute()
        {
            return cmds.Min();
        }
    }
}