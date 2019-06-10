using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Domain
{
    public class Item
    {
        public int Id { get; set; }
        [DisplayName("Titulo")]
        public string Titulo { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
    public class ItemList : List<Item>
    {

    }
}
