using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfigurantion : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(itp => itp.Id);

            builder
                .Property(itp => itp.ProdutoId)
                .IsRequired();
            
            builder
                .Property(itp => itp.Quantidade)
                .IsRequired();

        }
    }
}
