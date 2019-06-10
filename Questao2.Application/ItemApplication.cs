using NHibernate;
using Questao2.Domain;
using Questao2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Application
{
    public class ItemApplication
    {
        public Item SelectById(int id)
        {
            using (ISession session = NhibernateRepository.OpenSessionSQL())
            {
                return session.Get<Item>(id);
            }
        }

        public IList<Item> SelectAll()
        {
            using (ISession session = NhibernateRepository.OpenSessionSQL())
            {
                return session.Query<Item>().ToList();
            }
        }

        public void Save(Item item)
        {
            using (ISession session = NhibernateRepository.OpenSessionSQL())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(item);
                    transaction.Commit();
                }
            }
        }

        public void Update(Item item)
        {
            using (ISession session = NhibernateRepository.OpenSessionSQL())
            {
                var itemUpdate = session.Get<Item>(item.Id);
                itemUpdate.Titulo = item.Titulo; 
                itemUpdate.Descricao  = item.Descricao;

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(itemUpdate);
                    transaction.Commit();
                }
            }
        }

        public void Delete(int id)
        {
            using (ISession session = NhibernateRepository.OpenSessionSQL())
            {
                var itemDelete = session.Get<Item>(id);

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(itemDelete);
                    transaction.Commit();
                }
            }
        }
    }
}
