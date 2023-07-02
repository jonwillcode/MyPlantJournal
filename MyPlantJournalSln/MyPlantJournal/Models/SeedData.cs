using Microsoft.EntityFrameworkCore;

namespace MyPlantJournal.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PlantJournalDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<PlantJournalDbContext>();

            // Plants -- (Is this bad practice?)
            Guid _motherOfPerlesGuid = Guid.NewGuid();
            Guid _gollumJade = Guid.NewGuid();
            Guid _aeoniumKiwi = Guid.NewGuid();
            Guid _stringOfPearls = Guid.NewGuid();
            Guid _desertRose = Guid.NewGuid();
            Guid _prolifoca = Guid.NewGuid();
            Guid _scallopHybrid = Guid.NewGuid();

            // Plant Journal Event 
            Guid _waterEvent = Guid.NewGuid();
            Guid _observationEvent = Guid.NewGuid();
            Guid _pruneEvent = Guid.NewGuid();
            Guid _repotEvent = Guid.NewGuid();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Plants.Any())
            {
                context.Plants.AddRange(
                    new Plant
                    {
                        ID = _motherOfPerlesGuid,
                        Name = "Mother of Perles",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1), 
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant
                    {
                        ID = _gollumJade,
                        Name = "Gollum Jade",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant()
                    {
                        ID = _aeoniumKiwi,
                        Name = "Aeonium Kiwi",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant
                    {
                        ID = _stringOfPearls,
                        Name = "String of Pearls",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant
                    {
                        ID = _desertRose,
                        Name = "Desert Rose",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant
                    {
                        ID = _prolifoca,
                        Name = "Prolifoca",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    },
                    new Plant
                    {
                        ID = _scallopHybrid,
                        Name = "Scallop Hybrid",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent suscipit porttitor nisl, ac scelerisque justo finibus vitae. Aliquam erat volutpat. ",
                        Species = "Lorem Ipsum",
                        BirthDate = DateTime.Now.AddYears(-1),
                        CareStartedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        IsArchived = false,
                    }
                );
            }

            if (!context.JournalEventTypes.Any())
            {
                context.JournalEventTypes.AddRange(
                    new JournalEventType
                    {
                        ID = _waterEvent,
                        Name = "Water",
                        IsArchived = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,

                    }, 
                    new JournalEventType
                    {
                        ID = _observationEvent,
                        Name = "Observation",
                        IsArchived = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new JournalEventType
                    {
                        ID = _pruneEvent,
                        Name = "Prune",
                        IsArchived = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new JournalEventType
                    {
                        ID = _repotEvent,
                        Name = "Repot",
                        IsArchived = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    }
                );
            }

            if (!context.PlantJournalEvents.Any())
            {
                context.PlantJournalEvents.AddRange(
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _desertRose,
                            Notes = "Suspendisse tempus, magna eget lobortis dignissim, dui nibh eleifend justo, sed vehicula purus tellus ut lacus. Vestibulum vel consequat risus.",
                            IsArchived = false,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },

                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _gollumJade,
                            Notes = "Suspendisse tempus, magna eget lobortis dignissim, dui nibh eleifend justo, sed vehicula purus tellus ut lacus. Vestibulum vel consequat risus.",
                            IsArchived = false,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _prolifoca,
                            Notes = "Suspendisse tempus, magna eget lobortis dignissim, dui nibh eleifend justo, sed vehicula purus tellus ut lacus. Vestibulum vel consequat risus.",
                            IsArchived = false,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _gollumJade,
                            Notes = "Suspendisse tempus, magna eget lobortis dignissim, dui nibh eleifend justo, sed vehicula purus tellus ut lacus. Vestibulum vel consequat risus.",
                            IsArchived = false,
                            CreatedDate = DateTime.Now.AddDays(-4),
                            UpdatedDate = DateTime.Now.AddDays(-4),
                        },
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _gollumJade,
                            Notes = "",
                            IsArchived = false,
                            CreatedDate = DateTime.Now.AddDays(-8),
                            UpdatedDate = DateTime.Now.AddDays(-8),
                        },
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _waterEvent,
                            PlantID = _gollumJade,
                            Notes = "The time has come to repot it",
                            IsArchived = false,
                            CreatedDate = DateTime.Now.AddYears(-1),
                            UpdatedDate = DateTime.Now.AddYears(-1),
                        },
                        new PlantJournalEvent
                        {
                            ID = Guid.NewGuid(),
                            EventTypeID = _repotEvent,
                            PlantID = _gollumJade,
                            Notes = "",
                            IsArchived = false,
                            CreatedDate = DateTime.Now.AddYears(-1),
                            UpdatedDate = DateTime.Now.AddYears(-1),
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
