﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SistemaEscolar
    {

        public static string[,] GetListaAlunosMensalidades()
        {
            string[,] alunosArray = new string[5, 4] {
                {"101","Maria","Artes","1000" },
                {"102","Pedro","Engenharia","2000" },
                {"103","Bianca","Veterinariia","3000" }, 
                {"104","Pamela","Moda","900" }, 
                {"105","Sergio","Desenho","850" },                 
            };

            return alunosArray;
        }
    }
}
