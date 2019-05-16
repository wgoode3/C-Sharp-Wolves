using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Wolves.Models {
    public class WolfContext : DbContext {
        public WolfContext(DbContextOptions options) : base(options) { }
        public DbSet<Wolf> Wolves {get;set;}

        public Wolf GetWolfById(int Id)
        {
            return (Wolf)Wolves.Where(w => w.WolfId == Id).FirstOrDefault();
        }

        public void Create(Wolf wolf)
        {
            Add(wolf);
            SaveChanges();
        }

        public void Update(Wolf wolf)
        {
            Wolf results = GetWolfById(wolf.WolfId);
            if(results != null)
            {
                results.Name = wolf.Name;
                results.Type = wolf.Type;
                results.DOB = wolf.DOB;
                SaveChanges();
            }
        }

        public void DeleteById(int WolfId)
        {
            Remove(GetWolfById(WolfId));
            SaveChanges();
        }
    }
}
