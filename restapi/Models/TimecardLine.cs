using Newtonsoft.Json;
using System;

namespace restapi.Models
{
    public class TimecardLine
    {
        public int Week { get; set; }

        public int Year { get; set; }

        public DayOfWeek Day { get; set; }

        public float Hours { get; set; }

        public string Project { get; set; }
    }

    public class AnnotatedTimecardLine : TimecardLine
    {
        public AnnotatedTimecardLine(TimecardLine line)
        {
            Week = line.Week;
            Year = line.Year;
            Day = line.Day;
            Hours = line.Hours;
            Project = line.Project;

            Recorded = DateTime.UtcNow;
        }
        public DateTime Recorded { get; set; }

        public float LineNumber { get; set; }

        [JsonProperty("recId")]
        public int RecordIdentity { get; set; } = 0;

        [JsonProperty("recVersion")]
        public int RecordVersion { get; set; } = 0;

        public Guid UniqueIdentifier { get; set; }

        public DateTime PeriodFrom { get; set; }

        public DateTime PeriodTo { get; set; }

        public string Version { get; set; } = "line-0.1";
    }
}