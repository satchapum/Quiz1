public class EmployeeInfo {
    private string Type;
    private string Name;
    private string Surname;
    private double Age;
    private double Money;

    public EmployeeInfo(string Type, string Name, string Surname, double Age, double Money) {
        this.Type = Type;
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Money = Money;
    }

    public static string type(int input) {
        if(input == 1) {
            return "พนักงานประจำร้าน";
        }
        else if(input == 2) {
            return "พนักงานประจำร้าน";
        }
        else if(input == 3) {
            return "พนักงานประจำร้าน";
        }
        else if(input == 4) {
            return "พนักงานส่งอาหาร";
        }
        else {
            return "พนักงานส่งอาหาร";
        }
    }

    public static string name(int input) {
        if(input == 1) {
            return "นายชัยดี";
        }
        else if(input == 2) {
            return "นายนอนดี";
        }
        else if(input == 3) {
            return "นายอภัยดี";
        }
        else if(input == 4) {
            return "นายทำดี";
        }
        else {
            return "นายนอนดี";
        }
    }

    public static string surname(int input) {
        if(input == 1) {
            return "รักดี";
        }
        else if(input == 2) {
            return "ใจดี";
        }
        else if(input == 3) {
            return "เรียนดี";
        }
        else if(input == 4) {
            return "งานดี";
        }
        else {
            return "เรียบดี";
        }
    }

    public static double age(int input) {
        if(input == 1) {
            return 20;
        }
        else if(input == 2) {
            return 18;
        }
        else if(input == 3) {
            return 22;
        }
        else if(input == 4) {
            return 25;
        }
        else {
            return 23;
        }
    }

    public static double money(int person) {
        if(person == 1) {
            return 15000;
        }
        else if(person == 2) {
            return 15000;
        }
        else if(person == 3) {
            return 15000;
        }
        else if(person == 4) {
            return 12500;
        }
        else {
            return 12500;
        }
    }

    public static void PrintStoreInfo(EmployeeInfo Info) {
        Console.Write("Type : {0}",Info.Type);
        Console.Write(" Name : {0}",Info.Name);
        Console.Write(" Surname : {0}",Info.Surname);
        Console.Write(" Age : {0}",Info.Age);
        Console.WriteLine(" Salary : {0} Bath",Info.Money);
    }
}