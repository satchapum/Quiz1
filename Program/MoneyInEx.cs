public class MoneyInEx {
    private double Income;
    private double Expenses;
    private double Balance;

    public MoneyInEx(double Income, double Expenses, double Balance) {
        this.Income = Income;
        this.Expenses = Expenses;
        this.Balance = Balance;
    }

    public static double income() {
        return 236154;
    }

    public static double expenses() {
        return 213069.55;
    }

    public static double balance() {
        return 23684.45;
    }

    public static void PrintStoreInfo(MoneyInEx Info) {
        Console.WriteLine("Money Income : {0} Bath",Info.Income);
        Console.WriteLine(" Money Expenses : {0} Bath",Info.Expenses);
        Console.WriteLine(" Money balance : {0} Bath",Info.Balance);
    }
}