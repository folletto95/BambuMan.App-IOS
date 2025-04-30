namespace BambuMan.Interfaces
{
    public interface IInvokeIndent
    {
        Task SendEmail(string toEmail, string subject, string body);
    }
}
