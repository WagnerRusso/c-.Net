﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if(ProdutoId == 0)
            {
                LimparMensagensValidacao();
                AdicionarCritica("Não foi identicado qual a referência do produto");
            }
            if(Quantidade == 0)
            {
                LimparMensagensValidacao();
                AdicionarCritica("Quantidade não Informada");
            }
        }
    }
}
