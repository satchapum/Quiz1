public class StoreInfo {
    private double RegisteredCapital;
    private string BranchName;
    private string address;

    public StoreInfo(double RegisteredCapital, string BranchName, string address) {
        this.RegisteredCapital = RegisteredCapital;
        this.BranchName = BranchName;
        this.address = address;
    }

    public static double Capital() {
        return 1000000;
    }

    public static string Name() {
        return "KFC bang khun thian chaitalay";
    }

    public static string Address() {
        return "bang khun thian rd., soi 27";
    }

    public static void PrintStoreInfo(StoreInfo Info) {
        Console.WriteLine("********************************");
        Console.WriteLine("RegisteredCapital : {0}",Info.RegisteredCapital);
        Console.WriteLine("BranchName : {0}",Info.BranchName);
        Console.WriteLine("address : {0}",Info.address);
        Console.WriteLine("********************************");
    }
}