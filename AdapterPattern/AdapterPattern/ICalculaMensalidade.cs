﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ICalculaMensalidade
    {
        void ProcessaCalculoMensalidade(string[,] calculoMensalidade);
    }
}
