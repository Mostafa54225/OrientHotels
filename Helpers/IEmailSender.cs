namespace OrientHGAPI.Helpers
{
    public interface IEmailSender
    {
        void SendMail(string fromAddress, string toAddress, string mailSubject, string mailBody);
    }
}
