namespace MyPlantJournal.Models
{
    public class Plant
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Species { get; set; } = String.Empty;
        public DateTime BirthDate { get; set; }
        public string Notes { get; set; } = String.Empty;
        public bool IsArchived { get; set; } = false;
        public DateTime CareStartedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        public virtual ICollection<PlantJournalEvent> Events { get; set; }
    }
}
