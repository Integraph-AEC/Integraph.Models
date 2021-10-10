using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcSharedBldgElements;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integraph.Data
{
    public class Ifc4DbContext : DbContext
    {
        public DbSet<IfcColumn> Columns { get; set; }
        public DbSet<IfcPerson> People { get; set; }
        public DbSet<IfcAddress> Addresses { get; set; }
        public DbSet<IfcActorRole> ActorRoles { get; set; }

        public string DbPath { get; set; }

        public Ifc4DbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}Ifc.db";
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            var fromLabel = new ValueConverter<IfcLabel, string>(
               v => v.Value, v => new IfcLabel(v));
            //This would be the best!!!!!!!!!!!!!!!!!!!
            configurationBuilder
                .Properties<IfcLabel>()
                .HaveConversion<string>();

            configurationBuilder
                .Properties<IfcAddressTypeEnum>()
                .HaveConversion<string>();

            configurationBuilder
                .Properties<IfcText>()
                .HaveConversion<string>();

            configurationBuilder
                .Properties<IfcRoleEnum>()
                .HaveConversion<string>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var fromLabel = new ValueConverter<IfcLabel, string>(
                v => v.Value, v => new IfcLabel(v));

            modelBuilder
                .Entity<IfcAddress>()
                .Property(e => e.UserDefinedPurpose)
                .HasConversion(fromLabel);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}