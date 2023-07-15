namespace MarketPlace.Dtos.Responses
{
    public class CommonResponse<T>
    {
        public T? Data { get; set; }
        public String Message { get; set; } = "Something went wrong !";
        public int StatusCode { get; set; } = StatusCodes.Status500InternalServerError;
    }
}
