namespace MyPlantJournal.Models
{
    public interface IPlantJournalRepository
    {
        IQueryable<Plant> Plants { get; }
        IQueryable<PlantJournalEvent> Events { get; }
        IQueryable<JournalEventType> EventsType { get; }
    }
}
