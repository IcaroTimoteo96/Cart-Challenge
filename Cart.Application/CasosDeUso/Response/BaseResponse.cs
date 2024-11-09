namespace Cart.Application.CasosDeUso.Response
{
    public class BaseResponse<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }

        public BaseResponse()
        {

        }
        public BaseResponse(string message, bool success, T data)
        {
            Message = message;
            Success = success;
            Data = data;
        }
    }
}
