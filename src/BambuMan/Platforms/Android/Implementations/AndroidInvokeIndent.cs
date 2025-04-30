using Android.Content;
using BambuMan.Interfaces;
using Uri = Android.Net.Uri;

namespace BambuMan.Implementations
{
    public class AndroidInvokeIndent : IInvokeIndent
    {
        public Task SendEmail(string toEmail, string subject, string body)
        {
            var emailIntent = new Intent(Intent.ActionSendto);

            emailIntent.SetData(Uri.Parse("mailto:"));

            emailIntent.PutExtra(Intent.ExtraEmail, [toEmail]);
            emailIntent.PutExtra(Intent.ExtraSubject, subject);
            emailIntent.PutExtra(Intent.ExtraText, body);
            
            Platform.CurrentActivity?.StartActivity(emailIntent);

            return Task.CompletedTask;
        }
    }
}
