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

using Microsoft.Azure.PowerShell.Common.Config;
using System;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    public abstract class DataCollectionController
    {
        public const string RegistryKey = "DataCollectionController";
        public abstract AzurePSDataCollectionProfile GetProfile(Action warningWriter);

        static AzurePSDataCollectionProfile Initialize(IAzureSession session)
        {
            AzurePSDataCollectionProfile result = new AzurePSDataCollectionProfile(true);

            session.TryGetComponent<IConfigManager>(nameof(IConfigManager), out var configManager);
            Debug.Assert(configManager != null);
            var isNotSet = configManager.ListConfigs(new ConfigFilter()
            {
                Keys = new string[] { ConfigKeysForCommon.EnableDataCollection },
                AppliesTo = ConfigFilter.GlobalAppliesTo
            }).All(x => x.Scope == ConfigScope.Default);

            if (isNotSet)
            {
                WritePSDataCollectionProfile(session, result);
            }
            else
            {
                result.EnableAzureDataCollection = configManager.GetConfigValue<bool>(ConfigKeysForCommon.EnableDataCollection);
            }
            return result;
        }

        public static void WritePSDataCollectionProfile(IAzureSession session, AzurePSDataCollectionProfile profile)
        {
            session.TryGetComponent<IConfigManager>(nameof(IConfigManager), out var configManager);
            Debug.Assert(configManager != null);
            // todo: at what scope?
            // todo: what if profile.Enable... is null?

            try
            {
                configManager.UpdateConfig(ConfigKeysForCommon.EnableDataCollection, profile.EnableAzureDataCollection, ConfigScope.CurrentUser);
            }
            catch
            {
                // do not throw for i/o or serialization errors
            }
        }

        public static DataCollectionController Create(IAzureSession session)
        {
            return new MemoryDataCollectionController(Initialize(session));
        }

        public static DataCollectionController Create(AzurePSDataCollectionProfile profile)
        {
            return new MemoryDataCollectionController(profile);
        }

        class MemoryDataCollectionController : DataCollectionController
        {
            object _lock;
            bool? _enabled;

            public MemoryDataCollectionController()
            {
                _lock = new object();
                _enabled = null;
            }

            public MemoryDataCollectionController(AzurePSDataCollectionProfile enabled)
            {
                _lock = new object();
                _enabled = enabled?.EnableAzureDataCollection;
            }

            public override AzurePSDataCollectionProfile GetProfile(Action warningWriter)
            {
                lock (_lock)
                {
                    if (!_enabled.HasValue)
                    {
                        _enabled = true;
                        warningWriter();
                    }

                    return new AzurePSDataCollectionProfile(_enabled.Value);
                }
            }
        }
    }
}
