public abstract class CoffeeMashine
{
    public double coefficientTaste;
    public double coefficientCookSpeed;

    public void CookCoffee(CoffeeMashine coffeeMashine, int number)
    {
        Coffee coffee = null;

        switch (number)
        {
            case 0: coffee = new Americano(); coffee.taste = 2; break;
            case 1: coffee = new Latte(); coffee.taste = 3; break;
            case 2: coffee = new Mocha(); coffee.taste = 5; break;
        }

        coffee.taste *= coffeeMashine.coefficientTaste;
        coffee.cookingSpeed *= coffeeMashine.coefficientCookSpeed;  

        Console.WriteLine("Тип кофемашины: " + coffeeMashine.GetType());
        Console.WriteLine("Ваш выбор: " + coffee.GetType());
        Console.WriteLine();
        Console.WriteLine($"Время приготовления: {coffee.cookingSpeed} мин.");

        if (coffee.taste <= 3) Console.WriteLine("Вкус: такое себе...");
        else if (coffee.taste >= 3 && coffee.taste <= 5) Console.WriteLine("Вкус: норм...");
        else if (coffee.taste >= 5 && coffee.taste <= 7) Console.WriteLine("Вкус: вкусный!");
        else if (coffee.taste >= 7) Console.WriteLine("Вкус: охринительный!!!");
    } 
}