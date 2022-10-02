namespace CalculateCalories.ORM
{
    public class Result<T> where T: new()
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
