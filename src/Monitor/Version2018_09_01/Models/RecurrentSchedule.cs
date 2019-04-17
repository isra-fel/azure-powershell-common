// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The scheduling constraints for when the profile begins.
    /// </summary>
    public partial class RecurrentSchedule
    {
        /// <summary>
        /// Initializes a new instance of the RecurrentSchedule class.
        /// </summary>
        public RecurrentSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecurrentSchedule class.
        /// </summary>
        /// <param name="timeZone">the timezone for the hours of the profile.
        /// Some examples of valid time zones are: Dateline Standard Time,
        /// UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific
        /// Standard Time (Mexico), Pacific Standard Time, US Mountain Standard
        /// Time, Mountain Standard Time (Mexico), Mountain Standard Time,
        /// Central America Standard Time, Central Standard Time, Central
        /// Standard Time (Mexico), Canada Central Standard Time, SA Pacific
        /// Standard Time, Eastern Standard Time, US Eastern Standard Time,
        /// Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard
        /// Time, Central Brazilian Standard Time, SA Western Standard Time,
        /// Pacific SA Standard Time, Newfoundland Standard Time, E. South
        /// America Standard Time, Argentina Standard Time, SA Eastern Standard
        /// Time, Greenland Standard Time, Montevideo Standard Time, Bahia
        /// Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard
        /// Time, Cape Verde Standard Time, Morocco Standard Time, UTC, GMT
        /// Standard Time, Greenwich Standard Time, W. Europe Standard Time,
        /// Central Europe Standard Time, Romance Standard Time, Central
        /// European Standard Time, W. Central Africa Standard Time, Namibia
        /// Standard Time, Jordan Standard Time, GTB Standard Time, Middle East
        /// Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
        /// Standard Time, South Africa Standard Time, FLE Standard Time,
        /// Turkey Standard Time, Israel Standard Time, Kaliningrad Standard
        /// Time, Libya Standard Time, Arabic Standard Time, Arab Standard
        /// Time, Belarus Standard Time, Russian Standard Time, E. Africa
        /// Standard Time, Iran Standard Time, Arabian Standard Time,
        /// Azerbaijan Standard Time, Russia Time Zone 3, Mauritius Standard
        /// Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan
        /// Standard Time, West Asia Standard Time, Ekaterinburg Standard Time,
        /// Pakistan Standard Time, India Standard Time, Sri Lanka Standard
        /// Time, Nepal Standard Time, Central Asia Standard Time, Bangladesh
        /// Standard Time, N. Central Asia Standard Time, Myanmar Standard
        /// Time, SE Asia Standard Time, North Asia Standard Time, China
        /// Standard Time, North Asia East Standard Time, Singapore Standard
        /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar
        /// Standard Time, Tokyo Standard Time, Korea Standard Time, Yakutsk
        /// Standard Time, Cen. Australia Standard Time, AUS Central Standard
        /// Time, E. Australia Standard Time, AUS Eastern Standard Time, West
        /// Pacific Standard Time, Tasmania Standard Time, Magadan Standard
        /// Time, Vladivostok Standard Time, Russia Time Zone 10, Central
        /// Pacific Standard Time, Russia Time Zone 11, New Zealand Standard
        /// Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time, Tonga
        /// Standard Time, Samoa Standard Time, Line Islands Standard
        /// Time</param>
        /// <param name="days">the collection of days that the profile takes
        /// effect on. Possible values are Sunday through Saturday.</param>
        /// <param name="hours">A collection of hours that the profile takes
        /// effect on. Values supported are 0 to 23 on the 24-hour clock (AM/PM
        /// times are not supported).</param>
        /// <param name="minutes">A collection of minutes at which the profile
        /// takes effect at.</param>
        public RecurrentSchedule(string timeZone, IList<string> days, IList<int?> hours, IList<int?> minutes)
        {
            TimeZone = timeZone;
            Days = days;
            Hours = hours;
            Minutes = minutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timezone for the hours of the profile. Some
        /// examples of valid time zones are: Dateline Standard Time, UTC-11,
        /// Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard
        /// Time (Mexico), Pacific Standard Time, US Mountain Standard Time,
        /// Mountain Standard Time (Mexico), Mountain Standard Time, Central
        /// America Standard Time, Central Standard Time, Central Standard Time
        /// (Mexico), Canada Central Standard Time, SA Pacific Standard Time,
        /// Eastern Standard Time, US Eastern Standard Time, Venezuela Standard
        /// Time, Paraguay Standard Time, Atlantic Standard Time, Central
        /// Brazilian Standard Time, SA Western Standard Time, Pacific SA
        /// Standard Time, Newfoundland Standard Time, E. South America
        /// Standard Time, Argentina Standard Time, SA Eastern Standard Time,
        /// Greenland Standard Time, Montevideo Standard Time, Bahia Standard
        /// Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time,
        /// Cape Verde Standard Time, Morocco Standard Time, UTC, GMT Standard
        /// Time, Greenwich Standard Time, W. Europe Standard Time, Central
        /// Europe Standard Time, Romance Standard Time, Central European
        /// Standard Time, W. Central Africa Standard Time, Namibia Standard
        /// Time, Jordan Standard Time, GTB Standard Time, Middle East Standard
        /// Time, Egypt Standard Time, Syria Standard Time, E. Europe Standard
        /// Time, South Africa Standard Time, FLE Standard Time, Turkey
        /// Standard Time, Israel Standard Time, Kaliningrad Standard Time,
        /// Libya Standard Time, Arabic Standard Time, Arab Standard Time,
        /// Belarus Standard Time, Russian Standard Time, E. Africa Standard
        /// Time, Iran Standard Time, Arabian Standard Time, Azerbaijan
        /// Standard Time, Russia Time Zone 3, Mauritius Standard Time,
        /// Georgian Standard Time, Caucasus Standard Time, Afghanistan
        /// Standard Time, West Asia Standard Time, Ekaterinburg Standard Time,
        /// Pakistan Standard Time, India Standard Time, Sri Lanka Standard
        /// Time, Nepal Standard Time, Central Asia Standard Time, Bangladesh
        /// Standard Time, N. Central Asia Standard Time, Myanmar Standard
        /// Time, SE Asia Standard Time, North Asia Standard Time, China
        /// Standard Time, North Asia East Standard Time, Singapore Standard
        /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar
        /// Standard Time, Tokyo Standard Time, Korea Standard Time, Yakutsk
        /// Standard Time, Cen. Australia Standard Time, AUS Central Standard
        /// Time, E. Australia Standard Time, AUS Eastern Standard Time, West
        /// Pacific Standard Time, Tasmania Standard Time, Magadan Standard
        /// Time, Vladivostok Standard Time, Russia Time Zone 10, Central
        /// Pacific Standard Time, Russia Time Zone 11, New Zealand Standard
        /// Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time, Tonga
        /// Standard Time, Samoa Standard Time, Line Islands Standard Time
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the collection of days that the profile takes effect
        /// on. Possible values are Sunday through Saturday.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public IList<string> Days { get; set; }

        /// <summary>
        /// Gets or sets a collection of hours that the profile takes effect
        /// on. Values supported are 0 to 23 on the 24-hour clock (AM/PM times
        /// are not supported).
        /// </summary>
        [JsonProperty(PropertyName = "hours")]
        public IList<int?> Hours { get; set; }

        /// <summary>
        /// Gets or sets a collection of minutes at which the profile takes
        /// effect at.
        /// </summary>
        [JsonProperty(PropertyName = "minutes")]
        public IList<int?> Minutes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeZone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeZone");
            }
            if (Days == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Days");
            }
            if (Hours == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Hours");
            }
            if (Minutes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Minutes");
            }
        }
    }
}
