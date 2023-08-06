namespace EncapsulateWhatVaries
{
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstants.CheesePizza))
            {
                pizza = new Cheese();
            }
            else if (type.Equals(PizzaConstants.VegeterianPizza)) 
            {
                pizza = new Vegeterian();
            }
            else
            {
                pizza = new Chicken();
            }
            return pizza;
        }

        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);

            Prepare();
            Cook();
            Cut();
            return pizza;
        }

        private static void Prepare()
        {
            Console.WriteLine("Preparing...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cook()
        {
            Console.WriteLine("Cooking...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cut()
        {
            Console.WriteLine("Cutting and Boxing...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("C")}";
        }
    }
    class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}"; // Pizza Cheese
        public override decimal Price => base.Price + 3m;
    }
    class Chicken: Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}"; // Pizza Chicken 
        public override decimal Price => base.Price + 6m;
    }
    class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}"; // Pizza vegeterian 
        public override decimal Price => base.Price + 5m;
    }
}