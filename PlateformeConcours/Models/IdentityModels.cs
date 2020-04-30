using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using EntityFramework.DynamicFilters;
using PlateformeConcours.Models.Helper;

namespace PlateformeConcours.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext", throwIfV1Schema: false)
        {
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Etudiant3a> Etudiants3a { get; set; }
        public DbSet<Etudiant4a> Etudiants4a { get; set; }
        public DbSet<AncienEpreuve> AncienEpreuves { get; set; }
        public DbSet<Diplome> Diplomes { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Parametre> Parametres { get; set; }

		public DbSet<Cache> Cache { get; set; }
        public void AddFilters(ref DbModelBuilder modelBuilder)
        {
            modelBuilder.Filter("IsDeleted", (ISoftDelete d) => d.IsDeleted, false);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AddFilters(ref modelBuilder);
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}