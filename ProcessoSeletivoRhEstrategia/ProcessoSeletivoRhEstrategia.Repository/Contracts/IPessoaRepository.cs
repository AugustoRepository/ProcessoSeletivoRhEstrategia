using ProcessoSeletivo.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivoRhEstrategia.Repository.Contracts
{
    public interface IPessoaRepository
    {
        void Create(Pessoa pessoa);
        void UpDate(Pessoa pessoa);
        void Delete(Pessoa pessoa);

        List<Pessoa> GetAll();
        Pessoa GetById(int id);
    }
}
