﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
   public interface IStocareFurnizori:IStocareFactory
    {
        List<Furnizor> GetFurnizori();
    }
}
