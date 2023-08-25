using CampusFeedback.ViewModels;
using System.Threading.Tasks;

namespace CampusFeedback.Services
{
    public interface IMailService
    {
        void SendEmail(MailRequest mailRequest);
    }
}
