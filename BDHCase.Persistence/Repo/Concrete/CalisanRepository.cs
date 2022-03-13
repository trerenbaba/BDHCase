using BDHCase.Domain.models;
using BDHCase.Persistence.Context;
using BDHCase.Persistence.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDHCase.Persistence.Repo.Concrete
{
    public class CalisanRepository : EFBaseRepository<Calisan, AppDbContext>,ICalisanRepository
    {
        public CalisanRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

    }
}
