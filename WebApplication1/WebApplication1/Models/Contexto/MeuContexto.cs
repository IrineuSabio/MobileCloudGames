using System.Data.Entity;

namespace WebApplication1.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto(): base("strConnt")
        {

        }

        public System.Data.Entity.DbSet<Web.Models.WebApplication1.Models.item> items { get; set; }
    }
}