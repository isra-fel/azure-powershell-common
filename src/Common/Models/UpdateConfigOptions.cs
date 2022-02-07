﻿// ----------------------------------------------------------------------------------
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

namespace Microsoft.WindowsAzure.Commands.Common
{
    /// <summary>
    /// Options for updating a config. Used as input of <see cref="IConfigurationManager.UpdateConfig(UpdateConfigOptions)"/>
    /// </summary>
    public class UpdateConfigOptions<T>
    {
        public UpdateConfigOptions(string key, T value)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Value = value;
        }

        public string Key { get; }
        public T Value { get; }
        public ConfigScope Scope { get; set; } = ConfigScope.CurrentUser; // todo: maybe Scope should be mandatory when constructing UpdateConfigOptions. There's no obvious preference in the perspective of the library
        public string Module { get; set; } = null;
        public string Cmdlet { get; set; } = null;
    }
}
