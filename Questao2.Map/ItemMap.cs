using FluentNHibernate.Mapping;
using Questao2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Map
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Table("tbl_item");
            Id(x => x.Id).Column("Id").GeneratedBy.ToString();
            Map(x => x.Titulo).Column("Titulo");
            Map(x => x.Descricao).Column("Descricao");
        }
    }
}
