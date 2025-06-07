using Microsoft.EntityFrameworkCore;

namespace PRACTICA__4.context
{
    public class PaisesContext : DbContext
    {

        public PaisesContext(DbContextOptions<PaisesContext> db):base(db) { }
       
    }
}
