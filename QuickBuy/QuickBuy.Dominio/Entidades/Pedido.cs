using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario{ get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item pedido
        /// ou muitos itens de pedidos.
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            if (!ItensPedidos.Any())
            {
                LimparMensagensValidacao();
                AdicionarCritica("Critica -> Item de Pedido não pode ficar vazia");
            }
            if (string.IsNullOrEmpty(Cep))
            {
                LimparMensagensValidacao();
                AdicionarCritica("Critica -> CEP deve estar preenchido");
            }
        }
    }
}
