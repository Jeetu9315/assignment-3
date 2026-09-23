using System;

static class ApplicationConfiguration
{
    public static string ConnectionString =
        "Server=localhost;Database=UniversityDB;";

    public static string ApplicationName = "University Management System";
    public static string Version = "1.0";

    public static void DisplayConfiguration()
    {
        Console.WriteLine("Application Name: " + ApplicationName);
        Console.WriteLine("Version: " + Version);
        Console.WriteLine("Connection String: " + ConnectionString);
    }
}

class Program
{
    static void Main()
    {
        ApplicationConfiguration.DisplayConfiguration();
    }
}
