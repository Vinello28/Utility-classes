namespace Users;

public class Person
{
    private string name;
    private string surname;
    private DateOnly birth;

    public Person(string name, string surname, DateOnly birth)
    {
        this.name = name;
        this.surname = surname;
        this.birth = birth;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public DateOnly GetBirth()
    {
        return birth;
    }

    public int Age()
    {
        return DateTime.Now.Year - birth.Year;
    }
}