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

using System.Collections.Generic;

namespace Microsoft.WindowsAzure.Commands.Common
{
    /// <summary>
    /// Filter options for listing configurations. Used as input of some API of <see cref="IConfigurationManager" />
    /// </summary>
    public class ConfigFilter
    {
        public IEnumerable<string> Keys { get; set; } = null;
        public string Qualifier { get; set; } = null;
    }
}
