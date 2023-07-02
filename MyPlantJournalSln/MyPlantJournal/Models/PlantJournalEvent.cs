namespace MyPlantJournal.Models
{
    public class PlantJournalEvent
    {
        public Guid ID { get; set; }
        // TODO Add field for UserID!!!
        public Guid PlantID { get; set; }
        public Guid EventTypeID { get; set; }
        public string Notes { get; set; } = String.Empty;
        public bool IsArchived { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JournalEventType EventType { get; set; }
        public virtual Plant Plant { get; set; }

    }
}
