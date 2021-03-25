using System;
using System.Linq;

namespace Aplicacao
{
    public class CidadeService
    {
        private readonly CidadeRepository _cidadeRepository;

        public CidadeService(CidadeRepository cidadeRepository)
            => _cidadeRepository = cidadeRepository;

        public bool Create(Cidade cidade)
            => _cidadeRepository.Create(cidade);

        public bool Update(Cidade cidade)
            => _cidadeRepository.Update(cidade);

        public bool Remove(Cidade cidade)
            => _cidadeRepository.Remove(cidade);

        public IQueryable<Cidade> GetAll()
            => _cidadeRepository.GetAll();

        public Cidade FindById(Guid id)
            => _cidadeRepository.FindById(id);
    }
}