namespace Food.Exception
{
    public class DishAlreadyExistsException : ApplicationException
    {
        public DishAlreadyExistsException() { }
        public DishAlreadyExistsException(string msg) : base(msg) { }
    }
}
