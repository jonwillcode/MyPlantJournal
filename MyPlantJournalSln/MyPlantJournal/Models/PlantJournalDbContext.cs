using Microsoft.EntityFrameworkCore;

namespace MyPlantJournal.Models
{
    public class PlantJournalDbContext : DbContext
    {
        public PlantJournalDbContext(DbContextOptions<PlantJournalDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Plant> Plants => Set<Plant>();
        public DbSet<JournalEventType> JournalEventTypes => Set<JournalEventType>();
        public DbSet<PlantJournalEvent> PlantJournalEvents => Set<PlantJournalEvent>();
    }
}
