using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Shoppe.Model.EFStructures;
using Shoppe.Model.Settings;


namespace Model.EfStructures
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            string? projectRoot = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;
            string settingsPath = projectRoot + "\\Model\\Settings\\AppSettings.json";
            var appsetting = AppSettings.ReadAsJsonFormat(settingsPath);
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectString = appsetting.ConnectionStrings;
            optionsBuilder.UseSqlServer(connectString);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
