﻿public class Date
{
    public void DisplayCurrentTime()
    {
        Console.WriteLine("Time\t: {0}/{1}/{2}   {3}:{4}:{5}", date, month, year, hour, minute, second);

    }
    public Date(System.DateTime dt)
    {
        year = dt.Year;
        month = dt.Month;
        date = dt.Day;
        hour = dt.Hour;
        minute = dt.Minute;
        second = dt.Second;
    }
    public int Hour
    {
        get
        {
            return Hour;
        }
        set
        {
            hour = value;
        }
    }


    private int year;
    private int month;
    private int date;
    private int hour;
    private int minute;
    private int second;


    static void Main5(string[] args)
    {
        DateTime currentTime = System.DateTime.Now;
        Date d = new Date(currentTime);
        d.DisplayCurrentTime();

        int theHour = d.Hour;
        Console.WriteLine("Retrieved the hour: {0} ", theHour);
        theHour++;
        d.Hour = theHour;
        Console.WriteLine("Updated the hour: {0} ", theHour);
    }
}