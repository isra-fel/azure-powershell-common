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
    using System.Linq;

    /// <summary>
    /// The condition that results in the Log Search rule.
    /// </summary>
    public partial class TriggerCondition
    {
        /// <summary>
        /// Initializes a new instance of the TriggerCondition class.
        /// </summary>
        public TriggerCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggerCondition class.
        /// </summary>
        /// <param name="thresholdOperator">Evaluation operation for rule -
        /// 'GreaterThan' or 'LessThan. Possible values include: 'GreaterThan',
        /// 'LessThan', 'Equal'</param>
        /// <param name="threshold">Result or count threshold based on which
        /// rule should be triggered.</param>
        /// <param name="metricTrigger">Trigger condition for metric query
        /// rule</param>
        public TriggerCondition(string thresholdOperator, double threshold, LogMetricTrigger metricTrigger = default(LogMetricTrigger))
        {
            ThresholdOperator = thresholdOperator;
            Threshold = threshold;
            MetricTrigger = metricTrigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets evaluation operation for rule - 'GreaterThan' or
        /// 'LessThan. Possible values include: 'GreaterThan', 'LessThan',
        /// 'Equal'
        /// </summary>
        [JsonProperty(PropertyName = "thresholdOperator")]
        public string ThresholdOperator { get; set; }

        /// <summary>
        /// Gets or sets result or count threshold based on which rule should
        /// be triggered.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double Threshold { get; set; }

        /// <summary>
        /// Gets or sets trigger condition for metric query rule
        /// </summary>
        [JsonProperty(PropertyName = "metricTrigger")]
        public LogMetricTrigger MetricTrigger { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ThresholdOperator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ThresholdOperator");
            }
        }
    }
}
