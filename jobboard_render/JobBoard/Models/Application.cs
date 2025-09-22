namespace JobBoard.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public string Email { get; set; }
        public string Resume { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
