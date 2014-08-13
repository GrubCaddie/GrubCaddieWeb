using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrubCaddie.UI.Repository
{
    public interface IMenuItemRepository
    {
        IQueryable<MenuItem> GetMenuItem(Int32 Id);
        void Add(MenuItem menu);

        void Save();
    }
}
