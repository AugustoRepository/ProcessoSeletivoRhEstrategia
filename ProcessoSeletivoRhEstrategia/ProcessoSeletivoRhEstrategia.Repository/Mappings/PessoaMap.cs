using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessoSeletivo.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivoRhEstrategia.Repository.Mappings
{
    public class PessoaMap :IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("Id").IsRequired();

            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.SobreNome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(p => p.Nacionalidade).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Cep).HasMaxLength(8).IsRequired();
            builder.Property(p => p.Estado).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Logradouro).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Telefone).HasMaxLength(50).IsRequired();
        }
    }
}
