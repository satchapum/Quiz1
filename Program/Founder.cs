public class Founder {
    private string Name;
    private string Surname;
    private string IDNumber;

    public Founder(string Name, string Surname, string IDNumber) {
        this.Name = Name;
        this.Surname = Surname;
        this.IDNumber = IDNumber;
    }

    public static string name(int person) {
        if(person == 1) {
            return "นายทวี";
        }
        else if(person == 2) {
            return "นายยุทธดี";
        }
        else {
            return "นายเจมส์";
        }
    }

    public static string surname(int person) {
        if(person == 1) {
            return "ใจดีดี";
        }
        else if(person == 2) {
            return "ตั้งใจเรียน";
        }
        else {
            return "รักโรงเรียน";
        }
    }

    public static string IdNumber(int person) {
        if(person == 1) {
            return "153-698-4561237";
        }
        else if(person == 2) {
            return "742-112-5687412";
        }
        else {
            return "541-772-3215689";
        }
    }

    public static void PrintStoreInfo(Founder Info) {
        Console.Write("Name : {0}",Info.Name);
        Console.Write(" Surname : {0}",Info.Surname);
        Console.WriteLine(" IDnumber : {0}",Info.IDNumber);
    }
}