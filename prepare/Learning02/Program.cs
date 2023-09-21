using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Backend Developer";
        job1._company = "Eazipay";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "C.O Stores";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Divine Ahaka";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine($"{myResume._name} Resume");
        myResume.Display();
    }
}
