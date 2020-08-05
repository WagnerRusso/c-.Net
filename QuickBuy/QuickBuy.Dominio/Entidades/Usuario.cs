﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos{ get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {

            LimparMensagensValidacao();
                AdicionarCritica("Email não informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {

                LimparMensagensValidacao();
                AdicionarCritica("Senha não informada");
            }
        }
    }
}
