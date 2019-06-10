using Questao2.Domain;
using Questao2.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Application
{
    public class ItemApplicationADO
    {
        private BancoDados bdConexao;

        private void Insert(Item item)
        {
            var sql = "";
            sql += "INSERT INTO tbl_item(Titulo, Descricao)";
            sql += string.Format(" VALUES('{0}', '{1}')", item.Titulo, item.Descricao);

            using (bdConexao = new BancoDados())
            {
                bdConexao.ExecutaComando(sql);
            }
        }

        private void Update(Item item)
        {
            var sql = "";
            sql += "UPDATE tbl_item SET ";
            sql += string.Format(" Titulo = '{0}', Descricao = '{1}'", item.Titulo, item.Descricao);
            sql += string.Format(" Where Id = {0}", item.Id);

            using (bdConexao = new BancoDados())
            {
                bdConexao.ExecutaComando(sql);
            }
        }

        public void Save(Item item)
        {
            if (item.Id > 0)
            {
                Update(item);
            }
            else
            {
                Insert(item);
            }
        }

        public void Delete(int id)
        {
            using (bdConexao = new BancoDados())
            {
                var sql = string.Format("DELETE FROM tbl_item where Id = {0}", id);
                bdConexao.ExecutaComando(sql);
            }
        }

        public Item SelectById(int id)
        {
            using (bdConexao = new BancoDados())
            {
                var sql = string.Format("SELECT * FROM tbl_item where Id = {0}", id);

                var retorno = bdConexao.ExecutaComandoComRetorno(sql);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        public ItemList SelectAll()
        {
            using (bdConexao = new BancoDados())
            {
                var sql = "SELECT * FROM tbl_item";

                var retorno = bdConexao.ExecutaComandoComRetorno(sql);
                return ReaderEmLista(retorno);
            }
        }

        private ItemList ReaderEmLista(SqlDataReader reader)
        {
            var ItemLista = new ItemList();

            while (reader.Read())
            {
                var item = new Item()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    Descricao = reader["Descricao"].ToString(),
                };

                ItemLista.Add(item);
            }

            reader.Close();
            return ItemLista;
        }
    }
}
