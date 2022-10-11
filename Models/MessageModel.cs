namespace AnimalHotel.Models
{
    public class MessageModel
    {
        public string messageText;
        public bool Error;
        public MessageModel(string message, bool Error)
        {
            messageText = message;
            this.Error = Error;
        }
    }
}
