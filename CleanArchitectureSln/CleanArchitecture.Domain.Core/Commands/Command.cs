﻿using CleanArchitecture.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimesTamp { get; protected set; } 

        protected Command()
        {
            TimesTamp = DateTime.Now;
        }
    }
}
