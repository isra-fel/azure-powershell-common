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
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Common
{
    public interface IConfigManager
    {
        string ConfigFilePath { get; }
        void BuildConfig();
        T GetConfigValue<T>(string key, InvocationInfo invocation = null);
        object GetConfigValue(Type type, string key, InvocationInfo invocation = null);

        /// <summary>
        /// List all configs with values.
        /// </summary>
        /// <param name="filter">Filter the result by config key or level etc.</param>
        /// <returns></returns>
        IEnumerable<ConfigData> ListConfigs(ConfigFilter filter = null);
        IEnumerable<ConfigDefinition> ListConfigDefinitions();
        //T GetConfig<T>(string key) where T : Config;
        void RegisterConfig(ConfigDefinition config);

        ConfigData UpdateConfig(string key, object value);
        ConfigData UpdateConfig(UpdateConfigOptions options);

        void ClearConfig(string key);
        void ClearConfig(ClearConfigOptions options);
    }
}
