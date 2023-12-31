// <copyright file="ListenAndSampleAllActivitySources.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Diagnostics;
using Xunit;

namespace OpenTelemetry.Shims.OpenTracing.Tests;

[CollectionDefinition(nameof(ListenAndSampleAllActivitySources))]
public sealed class ListenAndSampleAllActivitySources : ICollectionFixture<ListenAndSampleAllActivitySources.Fixture>
{
    public sealed class Fixture : IDisposable
    {
        private readonly ActivityListener listener;

        public Fixture()
        {
            Activity.DefaultIdFormat = ActivityIdFormat.W3C;
            Activity.ForceDefaultIdFormat = true;

            this.listener = new ActivityListener
            {
                ShouldListenTo = _ => true,
                Sample = (ref ActivityCreationOptions<ActivityContext> options) => ActivitySamplingResult.AllData,
            };

            ActivitySource.AddActivityListener(this.listener);
        }

        public void Dispose()
        {
            this.listener.Dispose();
        }
    }
}
