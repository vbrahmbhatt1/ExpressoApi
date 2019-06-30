using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Image { get; set; }

        //added a collection navigaton property
        //one to many relationship between Menu and Submenus
        public ICollection<SubMenu> SubMenus { get; set; }

    }
}
