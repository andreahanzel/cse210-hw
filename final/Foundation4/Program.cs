using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a user profile, though it's not utilized in calculations as per the revised approach
        UserProfile userProfile = new UserProfile("IstvanHanzel", 40); 

        // Add Running activity
        userProfile.AddActivity(new Running(new DateTime(2024, 1, 10), 30, 3.0, 150));

        // Add Cycling activity
        userProfile.AddActivity(new Cycling(new DateTime(2024, 2, 15), 45, 20.0, 145));

        // Add Swimming activity
        userProfile.AddActivity(new Swimming(new DateTime(2024, 3, 20), 60, 20, 140));

        // Display summary for all activities
        userProfile.DisplayActivitiesSummary();
    }
}
