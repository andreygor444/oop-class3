namespace task1
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            var office = new Office();
            Business business = new();
            business.Subscribe(new Logger());
            business.Run(office);
        }
    }
}