public class Log
{
    protected int _breathingTimes;
    protected int _reflectingTimes;
    protected int _listingTimes;
    protected int _breathingSeconds;
    protected int _reflectingSeconds;
    protected int _listingSeconds;
    public void getLogs(string activityName, int activityTime)
    {
        if (activityName == "Breathing")
        {
            _breathingTimes ++;
            _breathingSeconds += activityTime;
        }
        else if (activityName == "Reflecting")
        {
            _reflectingTimes ++;
            _reflectingSeconds += activityTime;
        }
        else if (activityName == "Listing")
        {
            _listingTimes ++;
            _listingSeconds += activityTime;
        }
    }
    public string GetLogMessage()
    {
        string message = $"You have completed Breathing Activity {_breathingTimes} times totaling {_breathingSeconds} seconds.";
        message += $"\nYou have completed Reflecting Activity {_reflectingTimes} times totaling {_reflectingSeconds} seconds.";
        message += $"\nYou have completed Listing Activity {_listingTimes} times totaling {_listingSeconds} seconds.";
        return message;
    }

}