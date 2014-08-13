using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrubCaddie.UI.Repository
{
    public class ProfileRepository : IProfileRepository
    {
            protected readonly GrubCaddieContext GCContext;

            public ProfileRepository(GrubCaddieContext gc)
        {
            this.GCContext = gc;

        }

        public IQueryable<Data.Profile> GetProfileById(int Id)
        {
            var profile = (from c in GCContext.Profiles where c.Id == Id select c);
            return profile.AsQueryable();
        }

        public void Add(Data.Profile profile)
        {
            GCContext.Profiles.Add(profile);
        }

        public void Save()
        {
            GCContext.SaveChanges();
        }
    }
}