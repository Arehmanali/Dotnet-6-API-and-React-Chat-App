namespace ChatApp.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public ICollection<SentMessages> SentMessages { get; set; }
        public ICollection<RecieveMessages> RecieveMessages { get; set; }


    }
}
