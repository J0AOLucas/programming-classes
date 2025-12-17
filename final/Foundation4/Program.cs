using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 2, 1), 30, 3.0),
            new Cycling(new DateTime(2025, 2, 2), 40, 15.0),
            new Swimming(new DateTime(2025, 2, 3), 25, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}