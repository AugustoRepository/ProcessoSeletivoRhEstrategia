using Microsoft.EntityFrameworkCore;
using ProcessoSeletivo.Presentation.Model;
using ProcessoSeletivoRhEstrategia.Repository.Contexts;
using ProcessoSeletivoRhEstrategia.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessoSeletivoRhEstrategia.Repository.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext dataContext;

        public PessoaRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(Pessoa pessoa)
        {
            dataContext.Pessoa.Add(pessoa);
            dataContext.SaveChanges();
        }

        public void UpDate(Pessoa pessoa)
        {
            dataContext.Entry(pessoa).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Delete(Pessoa pessoa)
        {
            dataContext.Pessoa.Remove(pessoa);
            dataContext.SaveChanges();
        }

        public List<Pessoa> GetAll()
        {
            return dataContext.Pessoa.OrderByDescending(p => p.Id).ToList();
        }

        public Pessoa GetById(int id)
        {
            return dataContext.Pessoa.Find(id);
        }
    }
}
