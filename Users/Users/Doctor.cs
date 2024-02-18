namespace Users;

public class Doctor:User
{
    private string spec;

    public Doctor(string spec, string name, string surname, DateOnly birth, string email, string password) : 
        base(name, surname, birth, email, password)
    {
        this.spec = spec;
    }


    public string GetSpec()
    {
        return spec;
    }

    public void SetSpec(string _spec)
    {
        spec = _spec;
    }

    public Illness AddIllness(string name, string descr, string treat, Symptoms[] sym)
    {
        return new Illness(name, descr, treat, sym);
    }
    
}