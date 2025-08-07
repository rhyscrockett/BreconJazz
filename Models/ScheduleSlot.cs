namespace BreconJazz.Models
{
    public class ScheduleSlot
    {
        public int Id { get; set; }
        public Band Band { get; set; }
        public Venue Venue { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
