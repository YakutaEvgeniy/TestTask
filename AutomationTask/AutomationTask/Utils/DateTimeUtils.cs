using AutomationTask.Constatns;
using AutomationTask.ObjectsForJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTask.Utils
{
    public static class DateTimeUtils
    {
        private static int startMorningHour = 6;
        private static int startDayHour = 12;
        private static int startEveningHour = 18;
        private static int startNightHour = 0;

        private static Message Messages = FileReader.JsonReader<Message>(FilePaths.PATH_TO_MESSAGE_DATA);

        public static string GetMessageByTime()
        {
            int hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if(startMorningHour <= hour && hour < startDayHour)
            {
                return Messages.MorningMessage;
            }
            else if(startDayHour <= hour && hour < startEveningHour)
            {
                return Messages.DayMessage;
            }
            else if (hour < startMorningHour)
            {
                return Messages.NightMessage;
            }
            else
            {
                return Messages.EveningMessage;
            }
        }
    }
}
