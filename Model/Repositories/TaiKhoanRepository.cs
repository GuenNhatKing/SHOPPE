using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EfStructures;
using Shoppe.Model.EFStructures;
using Shoppe.Model.Entities;

namespace Shoppe.Model.Repositories
{
    public class TaiKhoanRepository
    {
        private ApplicationDbContext _context = null!;
        public TaiKhoanRepository()
        {
            _context = new ApplicationDbContextFactory().CreateDbContext(null!);
        }

        public List<TaiKhoan> LayDSTaiKhoan()
        {
            return _context.TaiKhoans.ToList();
        }
    }
}
