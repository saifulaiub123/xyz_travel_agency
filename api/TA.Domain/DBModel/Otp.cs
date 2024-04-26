using TA.Domain.Model;

namespace TA.Domain.DBModel
{
    public class Otp : BaseModel<int>
    {
        public string MobileNumber { get; set; }
        public string VerificationCode { get; set; }
        public DateTime ExpiredAt { get; set; }
        public bool IsVerified { get; set; }
    }
}
