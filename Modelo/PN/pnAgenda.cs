using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class pnAgenda
    {
        public static bool Inserir (Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                if (pnAgenda.Pesquisar(p.Email)!=null)
                {
                    return false;
                }
                db.Pessoas.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Alterar(Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                Pessoa pa = new Pessoa();

                pa = db.Pessoas.Find(p.UserID);

                pa.Idade = p.Idade;
                pa.Nome = p.Nome;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Excluir(Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                Pessoa pa = new Pessoa();

                pa = db.Pessoas.Find(p.Email);

                if (pa != null)
                    db.Pessoas.Remove(pa);
                else
                    return false;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Pessoa Pesquisar(String email)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                

                return db.Pessoas.Find(email);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Pessoa> Listar()
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                return db.Pessoas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Pessoa Pesquisar(Guid userid)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();


                return db.Pessoas.Find(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
