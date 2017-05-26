using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenQbit.Weather.Common.Models;

namespace OpenQbit.Weather.DAL.DataAccess
{
    public class WeatherContext : DbContext
    {
        public WeatherContext() : base("WeatherDB")
        {

            this.Configuration.ProxyCreationEnabled = false;

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<Daydetail> Daydetail { get; set; }
        public DbSet<Forecast> Forecast { get; set; }
        public DbSet<Forecastdetail> Forecastdetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
