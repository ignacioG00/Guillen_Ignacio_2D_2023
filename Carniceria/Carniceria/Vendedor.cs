﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    internal class Vendedor : Usuario
    {
        public Vendedor(string nombre, int dni, string contraseña) : base(nombre, dni, contraseña)
        {

        }
    }
}
