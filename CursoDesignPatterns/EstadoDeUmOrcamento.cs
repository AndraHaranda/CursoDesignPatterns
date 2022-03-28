﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    interface EstadoDeUmOrcamento
    {
        void AplicacaoDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);   
        void Reprova(Orcamento orcamento);  
        void Finaliza(Orcamento orcamento); 

    }
}
