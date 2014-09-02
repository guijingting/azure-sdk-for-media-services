﻿// Copyright 2014 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Net;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Represents an IP Range
    /// This is the public class exposed to SDK interfaces and used by users
    /// </summary>
    /// ReSharper disable once InconsistentNaming
    public class IPRange
    {
        /// <summary>
        /// Gets or sets a friendly name for this IP Range.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The base IP address for this CIDR range.
        /// </summary>
        public IPAddress Address { get; set; }

        /// <summary>
        /// The subnet mask prefix length (see CIDR notation).
        /// </summary>
        public int? SubnetPrefixLength { get; set; }
    }
}