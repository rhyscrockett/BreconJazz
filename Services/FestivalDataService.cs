namespace BreconJazz.Services
{
    public class FestivalDataService
    {
        public List<Band> GetBands() => new()
        {
            new Band { Id = 1, Name = "The Electric Owls", Genre = "Indie Rock", Description = "Energetic and soulful.", SocialLink = "https://twitter.com/electricowls", AudioSampleUrl = "/samples/owl.mp3" },
            new Band { Id = 2, Name = "Banjo Blitz", Genre = "Folk", Description = "Traditional banjo melodies.", SocialLink = "https://facebook.com/banjoblitz", AudioSampleUrl = "/samples/banjo.mp3" }
        };

        public List<Venue> GetVenues() => new()
        {
            new Venue { Id = 1, Name = "Main Stage", Location = "North Park", Capacity = 1000 },
            new Venue { Id = 2, Name = "Acoustic Tent", Location = "South Meadow", Capacity = 250 }
        };

        public List<ScheduleSlot> GetSchedule() => new()
        {
            new ScheduleSlot
            {
                Id = 1,
                Band = GetBands()[0],
                Venue = GetVenues()[0],
                StartTime = DateTime.Today.AddHours(12),
                EndTime = DateTime.Today.AddHours(13)
            },
            new ScheduleSlot
            {
                Id = 2,
                Band = GetBands()[1],
                Venue = GetVenues()[1],
                StartTime = DateTime.Today.AddHours(13),
                EndTime = DateTime.Today.AddHours(14)
            }
        };
    }
}
