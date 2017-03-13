namespace ShareClientDotNet
{
    internal static class ShareKnownRemoteErrorCodes
    {
        public const string AuthenticateAccountNotFound = "SSO_AuthenticateAccountNotFound";
        public const string AuthenticatePasswordInvalid = "SSO_AuthenticatePasswordInvalid";
        public const string AuthenticateMaxAttemptsExceeed = "SSO_AuthenticateMaxAttemptsExceeed";

        // these two will be handled internally
        // SessionIdNotFound
        // SessionNotValid"
    }
}