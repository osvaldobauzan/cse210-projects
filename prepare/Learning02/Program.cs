using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resu = new Resume();
    
        job1._company = "MS Tecs";
        job1._jobTitle = "Trainer";
        job1._startYear = 2021;
        job1._endYear = 2023;

        job2._company = "Nissan";
        job2._jobTitle = "Ing";
        job2._startYear = 1998;
        job2._endYear = 2023;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        resu._jobs.Add(job1);
        resu._jobs.Add(job2);
        resu._name = "Osvaldo Bauzan";

        // Console.WriteLine(resu._jobs[0]._jobTitle);

        resu.DisplayResume();
    }
}
