namespace GitHubPractice.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; } = DateTime.Now;
        public DateTime? DateOfBirth { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}
