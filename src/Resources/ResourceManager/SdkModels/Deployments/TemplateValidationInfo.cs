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

using System.Collections.Generic;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels
{
    public class TemplateValidationInfo
    {
        public TemplateValidationInfo(List<Provider> requiredProviders, List<ErrorDetail> errors, List<DeploymentDiagnosticsDefinition> diagnostics)
        {
            Errors = errors;
            RequiredProviders = requiredProviders;
            Diagnostics = diagnostics;
        }

        public List<ErrorDetail> Errors { get; set; }

        public List<Provider> RequiredProviders { get; set; }

        public List<DeploymentDiagnosticsDefinition> Diagnostics { get; set; }
    }
}
