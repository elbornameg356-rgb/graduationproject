using System.Threading.Tasks;

namespace OutpatientClinicsComplex.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}