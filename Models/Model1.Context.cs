//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IQISService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class feedbackEntities : DbContext
    {
        public feedbackEntities()
            : base("name=feedbackEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<area> areas { get; set; }
        public DbSet<AreaCategory> AreaCategories { get; set; }
        public DbSet<ColorCode> ColorCodes { get; set; }
        public DbSet<CoordinatesReference> CoordinatesReferences { get; set; }
        public DbSet<countermeasure> countermeasures { get; set; }
        public DbSet<defect> defects { get; set; }
        public DbSet<FEEDBACK_DATA> FEEDBACK_DATA { get; set; }
        public DbSet<location> locations { get; set; }
        public DbSet<model> models { get; set; }
        public DbSet<OverflowResponsible> OverflowResponsibles { get; set; }
        public DbSet<part> parts { get; set; }
        public DbSet<ResponsibleGroup> ResponsibleGroups { get; set; }
        public DbSet<responsible> responsibles { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<round> rounds { get; set; }
        public DbSet<screen> screens { get; set; }
        public DbSet<userRolesMapping> userRolesMappings { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<WeldingCoordinate> WeldingCoordinates { get; set; }
    }
}
