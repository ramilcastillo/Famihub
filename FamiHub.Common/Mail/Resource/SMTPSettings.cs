namespace FamiHub.Common.Mail.Resource
{
    public class SMTPSettings
    {
        public string DefaultFromAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
