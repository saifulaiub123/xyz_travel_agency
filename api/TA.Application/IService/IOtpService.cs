using TA.Application.Response;
using TA.Domain.Model;

namespace TA.Application.IService
{
    public interface IOtpService
    {
        Task SendOtp(string mobileNumber);
        Task<OtpResponse> VerifyOtp(VerifyOtp verifyOtp);
    }
}
