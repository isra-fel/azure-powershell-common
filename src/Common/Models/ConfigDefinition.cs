// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Microsoft.WindowsAzure.Commands.Common
{
    public abstract class ConfigDefinition
    {
        public abstract object DefaultValue { get; }

        public abstract string Key { get; }

        public abstract string HelpMessage { get; }

        public virtual string EnvironmentVariableName { get; } = null;

        public virtual IReadOnlyCollection<ConfigLevel> ApplicableLevels => new ConfigLevel[] { ConfigLevel.Az, ConfigLevel.Module, ConfigLevel.Cmdlet };

        /// <summary>
        /// Validates if the input value can be set to this config. Throws an exception if not.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public virtual void Validate(object value) { }

        public abstract Type ValueType { get; }
    }
}