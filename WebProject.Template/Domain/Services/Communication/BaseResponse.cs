namespace WebProject.Template.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        protected BaseResponse(bool success, string message)
        {
            Message = message;
            Success = success;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}