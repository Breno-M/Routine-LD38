using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {

    public Text timeText;
    public Text dayText;
    public Text weekDayText;

    public float nextSecond = 1;

    public float second;
    public float hour;
    public float day; 
    public float month;
    public float year;

    void Update()
    {
        if (nextSecond > 0)
        {
            nextSecond -= Time.deltaTime;
            second += 1.2f;
        }

        else
        {
            nextSecond = 1;
            hour += 1f;
        }

        if(second >= 60)
        {
            second = 0;
        }

        if (hour >= 24)
        {
            hour = 0;
            day += 1;
        }

        if (day >= 30)
        {
            day = 0;
            month += 1;
        }

        if (month >= 12)
        {
            month = 0;
            year += 1;
        }

        string hourTxt = (int)hour < 10 ? "0" + (int)hour : ((int)hour).ToString();
        //string secondTxt = (int)second < 10 ? "0" + (int)second : ((int)second).ToString();

        dayText.text = "DAY " + day;
        timeText.text = hourTxt + ":00";
        weekDayText.text = GetWeekDay(day);

    }

    public string GetWeekDay(float day)
    {
        string weekday = "";

        if (day % 7 == 0)
            weekday = "TUESDAY";
        else if (day % 7 == 1)
            weekday = "WEDNESDAY";
        else if (day % 7 == 2)
            weekday = "THURSDAY";
        else if (day % 7 == 3)
            weekday = "FRIDAY";
        else if (day % 7 == 4)
            weekday = "SATURDAY";
        else if (day % 7 == 5)
            weekday = "SUNDAY";
        else if (day % 7 == 6)
            weekday = "MONDAY";

        return weekday;

    }

}
