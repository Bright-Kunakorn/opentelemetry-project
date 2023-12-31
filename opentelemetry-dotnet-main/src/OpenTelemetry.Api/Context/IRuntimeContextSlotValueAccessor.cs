// <copyright file="IRuntimeContextSlotValueAccessor.cs" company="OpenTelemetry Authors">
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

namespace OpenTelemetry.Context;

/// <summary>
/// Describes a type of <see cref="RuntimeContextSlot{T}"/> which can expose its value as an <see cref="object"/>.
/// </summary>
public interface IRuntimeContextSlotValueAccessor
{
    /// <summary>
    /// Gets or sets the value of the slot as an <see cref="object"/>.
    /// </summary>
    object Value { get; set; }
}
