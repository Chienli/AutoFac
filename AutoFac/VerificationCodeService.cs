using System;

namespace AutoFac
{
    internal class VerificationCodeService : IVerification
    {
        public int GetVerificationCode()
        {
            var verificationCode = new Random().Next(1000, 9999);
            return verificationCode;
        }
    }
}