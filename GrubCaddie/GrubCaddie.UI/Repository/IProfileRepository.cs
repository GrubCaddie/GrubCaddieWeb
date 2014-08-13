using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrubCaddie.UI.Repository
{
    public interface IProfileRepository
    {

        IQueryable<Profile> GetProfileById(Int32 Id);
        void Add(Profile menu);

        void Save();
    }
}
