﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.Infrastructure
{
    public interface IViewModel
    {
        IView View { get; set; }
    }
}