namespace MyPlantJournal.Models
{
    public class JournalEventType
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public bool IsArchived { get; set; } = false;


        public virtual ICollection<PlantJournalEvent> Events { get; set; }

    }
}
