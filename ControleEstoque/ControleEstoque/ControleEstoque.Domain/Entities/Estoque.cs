﻿using System.Collections.Generic;

namespace ControleEstoque.Domain.Entities
{
   public class Estoque :Entity
    {      
        public IEnumerable<MovimentoEstoque> MovimentosEstoque { get; private set;}

    }
}
