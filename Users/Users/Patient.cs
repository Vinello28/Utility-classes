namespace Users;

public class Patient:Person
{
    public bool Diagnosis { get; set; }
    public Illness illness { get; set; }
    public Doctor Doc { get; set;}

    public Patient(Doctor d, string name, string surname, DateOnly birth) : base(name, surname, birth)
    {
        Diagnosis = false;
        Doc = d;
    }

    public void AddDiagnosisIllnessUnknown(Symptoms[] sym, string description)
    {
        Diagnosis = true;
        Doc.AddIllness("unknown", description, "unknown", sym);
    }
    public void AddDiagnosis(Illness i)
    {
        Diagnosis = true;
        illness = i;
    }
}