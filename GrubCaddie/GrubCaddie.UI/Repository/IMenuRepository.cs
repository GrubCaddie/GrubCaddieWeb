using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrubCaddie.UI.Repository
{
    public interface IMenuRepository 
    {

        IQueryable<Menu> GetAllMenu();
        void Add(Menu menu);

        void Save();

    }
}
