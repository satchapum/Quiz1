namespace Test;

public class UnitTest1
{
    [Fact]
    public void EmployeeInfoTest()
    {
        int person = 1;
        string type = EmployeeInfo.type(person);
        string name = EmployeeInfo.name(person);
        string surname = EmployeeInfo.surname(person);
        double age = EmployeeInfo.age(person);
        double money = EmployeeInfo.money(person);
        EmployeeInfo Info = new EmployeeInfo(type,name,surname,age,money);
        
        Assert.Equal(EmployeeInfo.type(person), "พนักงานประจำร้าน");
    }
    [Fact]
    public void EmployeeInfoTest()
    {
        int person = 1;
        string type = EmployeeInfo.type(person);
        string name = EmployeeInfo.name(person);
        string surname = EmployeeInfo.surname(person);
        double age = EmployeeInfo.age(person);
        double money = EmployeeInfo.money(person);
        EmployeeInfo Info = new EmployeeInfo(type,name,surname,age,money);
        
        Assert.Equal(EmployeeInfo.type(person), "พนักงานประจำร้าน");
    }
}