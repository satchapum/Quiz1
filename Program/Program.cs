class Program {

    public static string InputMenuNumber() {
        Console.Write("Please select number :");
        return Console.ReadLine();
    }

    public static int InputMenuNumber(string Input) {
        if(int.TryParse(Input, out int number)){
            return number;
        }

        throw new Exception ("Please input number");
    }

    public static void Information(int InputNumber) {
        if(InputNumber == 1) {
            double capital = StoreInfo.Capital();
            string name = StoreInfo.Name();
            string address = StoreInfo.Address();
            StoreInfo Info = new StoreInfo(capital,name,address);

            StoreInfo.PrintStoreInfo(Info);
        }
        else if(InputNumber == 2) {
            Console.WriteLine("***************************************");
            for (int person = 1; person <= 3; person++) {
            string name = Founder.name(person);
            string surname = Founder.surname(person);
            string idNumber = Founder.IdNumber(person);
            Founder Info = new Founder(name,surname,idNumber);

            Founder.PrintStoreInfo(Info);
            }
            Console.WriteLine("***************************************");
        }
        else if(InputNumber == 3) {
            Console.WriteLine("***************************************");
            for (int person = 1; person <= 5; person++) {
            string type = EmployeeInfo.type(person);
            string name = EmployeeInfo.name(person);
            string surname = EmployeeInfo.surname(person);
            double age = EmployeeInfo.age(person);
            double money = EmployeeInfo.money(person);
            EmployeeInfo Info = new EmployeeInfo(type,name,surname,age,money);

            EmployeeInfo.PrintStoreInfo(Info);
            }
            Console.WriteLine("***************************************");
        }

        else if(InputNumber == 4) {
            Console.WriteLine("***************************************");
            double Income = MoneyInEx.income();
            double Expenses = MoneyInEx.expenses();
            double Balance = MoneyInEx.balance();
            MoneyInEx Info = new MoneyInEx(Income,Expenses,Balance);

            MoneyInEx.PrintStoreInfo(Info);
            Console.WriteLine("***************************************");
        }

        else {
            throw new Exception ("Please input number 1-4");
        }
    }
    
    public static void Main(string[] args) {

        PrintMenuSelect();
        
        string InputText = InputMenuNumber();
        int InputNumber = InputMenuNumber(InputText);

        Information(InputNumber);
    }

    public static void PrintMenuSelect() {
        Console.WriteLine("             Menu");
        Console.WriteLine("********************************");
        Console.WriteLine("1.Store Information ");
        Console.WriteLine("2.Founder ");
        Console.WriteLine("3.Employee information");
        Console.WriteLine("4.Income and expenses information");
        Console.WriteLine("********************************");
    }
}