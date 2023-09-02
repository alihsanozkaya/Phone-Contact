namespace Phone_Contact.Core.Results
{
    public class Result : IResult
    {
        public Result(string message, bool success)
        {
            Success = success;
            Message = message;

        }
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
