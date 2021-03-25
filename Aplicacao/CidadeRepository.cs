using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao
{
    public class CidadeRepository
    {
        public virtual bool Create(Cidade cidade)
            => true;

        public virtual bool Update(Cidade cidade)
            => true;

        public virtual bool Remove(Cidade cidade)
            => true;

        public virtual IQueryable<Cidade> GetAll()
        {
            IList<Cidade> cidades = new List<Cidade>();
            cidades.Add(new Cidade("Fortaleza"));
            cidades.Add(new Cidade("São Paulo"));

            return cidades.AsQueryable();
        }

        public virtual Cidade FindById(Guid id)
            => new Cidade(id, "Fortaleza");
    }
}