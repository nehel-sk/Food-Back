namespace Food.Exception
{
    public class DishNotFoundException : ApplicationException
    {
        public DishNotFoundException() { }
        public DishNotFoundException(string msg) : base(msg) { }
    }
}
