namespace Users;

public class Illness
{
    private string name;
    private string description;
    private string treatment;
    private Symptoms[] symptomsArray;

    public Illness(string name, string description, string treatment, Symptoms[] sym)
    {
        this.name = name;
        this.description = description;
        this.treatment = treatment;
        this.symptomsArray = sym;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetTreatment()
    {
        return treatment;
    }

    public Symptoms[] GetSymptoms()
    {
        return symptomsArray;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetTreatment(string treatment)
    {
        this.treatment = treatment;
    }

    public void SetSymptoms(Symptoms symptoms, int pos)
    {
        symptomsArray[pos] = symptoms;
    }
}