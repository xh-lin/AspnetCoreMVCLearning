using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess.Data;
using WebApp.DataAccess.Repository.IRepository;
using WebApp.Models;

namespace WebApp.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
