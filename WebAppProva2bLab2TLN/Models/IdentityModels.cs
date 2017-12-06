using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebAppProva2bLab2TLN.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebAppProva2bLab2TLN.Models.Clube> Clubes { get; set; }

        public System.Data.Entity.DbSet<WebAppProva2bLab2TLN.Models.Socio> Socios { get; set; }

        public System.Data.Entity.DbSet<WebAppProva2bLab2TLN.Models.Servico> Servicoes { get; set; }

        public System.Data.Entity.DbSet<WebAppProva2bLab2TLN.Models.Endereco> Enderecoes { get; set; }

        public System.Data.Entity.DbSet<WebAppProva2bLab2TLN.Models.Tipo> Tipoes { get; set; }
    }
}