namespace BreconJazz.Models
{
    public class Band
    {
        public int Id { get; set; } // For linking purposes
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string SocialLink { get; set; }
        public string AudioSampleUrl { get; set; }
    }
}
