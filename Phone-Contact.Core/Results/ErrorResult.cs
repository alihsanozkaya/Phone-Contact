namespace Phone_Contact.Core.Results
{
    public class ErrorResult : Result
    {

        public ErrorResult(string message, bool success = false) : base(message, success)
        {
        }
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
