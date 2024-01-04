namespace CQRSMediatRExample.API.Models
{
    public class CustomResult<T>(string message = "", bool success = true, T? data = default) 
    {
        public string Message { get; set; } = message;
        public T? Data { get; set; } = data;
        public bool Success { get; set; } = success;
    }
}
