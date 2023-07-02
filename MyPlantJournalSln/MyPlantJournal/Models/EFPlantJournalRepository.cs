namespace MyPlantJournal.Models
{
    public class EFPlantJournalRepository : IPlantJournalRepository
    {
        private PlantJournalDbContext _context;
        public EFPlantJournalRepository(PlantJournalDbContext context)
        {
            _context = context;
        }
        public IQueryable<Plant> Plants => _context.Plants;

        public IQueryable<PlantJournalEvent> Events => _context.PlantJournalEvents;

        public IQueryable<JournalEventType> EventsType => _context.JournalEventTypes;
    }
}
