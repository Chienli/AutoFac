using System;

namespace AutoFac
{
    internal class AuthenticationService
    {
        private readonly ILogger _logger;
        private readonly IVerification _verificationCodeService;

        public AuthenticationService(ILogger logger, IVerification verificationCodeService)
        {
            _logger = logger;
            _verificationCodeService = verificationCodeService;
        }

        public bool Login(string account, string password)
        {
            if (account == "Guy" && password == "i am password")
            {
                _logger.ConsoleLog(account + " is logged");

                var verificationCode = _verificationCodeService.GetVerificationCode();
                _logger.ConsoleLog($"驗證碼:{verificationCode}");

                _logger.ConsoleLog("請輸入上述驗證碼:");
                var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                return input == verificationCode;
            }
            else
            {
                return false;
            }
        }
    }
}