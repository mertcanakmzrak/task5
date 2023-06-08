using System;
using System.Collections.Generic;

public interface IDoctor
{
    string Specialization { get; set; }
    void ConductExamination();
    void PerformSurgery();
}

public abstract class Surgeon : IDoctor
{
    public string Specialization { get; set; }
    public string Department { get; set; }


    public abstract void PerformSurgery();

    public void ConductExamination()
    {
        Console.WriteLine("Conducting patient examination.");
    }

    protected void RegisterSurgery()
    {
        Console.WriteLine("Surgery registered.");
    }

    protected void PreparePatient()
    {
        Console.WriteLine("Preparing the patient for surgery.");
    }
}

public class Neurosurgeon : Surgeon
{
    public string AdditionalSpecialization { get; set; }
    public int NumberOfNeurosurgeries { get; private set; }

    public override void PerformSurgery()
    {
        
        Console.WriteLine("Performing neurosurgery.");
        
    }

    public void PerformLaserSurgery()
    {
        Console.WriteLine("Performing surgery using laser equipment.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var doctorList = new List<IDoctor>();
        var neurosurgeon1 = new Neurosurgeon
        {
            Specialization = "Neurosurgery",
            Department = "Neurosurgery Department",
            AdditionalSpecialization = "Laser neurosurgery specialization"
        };

        var neurosurgeon2 = new Neurosurgeon
        {
            Specialization = "Neurosurgery",
            Department = "Neurosurgery Department",
            AdditionalSpecialization = "Deep brain stimulation specialization"
        };

        doctorList.Add(neurosurgeon1);
        doctorList.Add(neurosurgeon2);

        foreach (var doctor in doctorList)
        {
            doctor.ConductExamination();
            doctor.PerformSurgery();
        }

        Console.ReadLine();
    }
}
