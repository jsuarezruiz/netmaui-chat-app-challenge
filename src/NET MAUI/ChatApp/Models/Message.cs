namespace ChatApp.Models
{
    public class Message
    {
        public User Sender { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
    }
}