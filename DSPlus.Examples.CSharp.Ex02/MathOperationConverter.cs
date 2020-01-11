﻿// THIS FILE IS A PART OF EMZI0767'S BOT EXAMPLES
//
// --------
// 
// Copyright 2019 Emzi0767
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// --------
//
// This is a commands example. It shows how to properly utilize 
// CommandsNext, as well as use its advanced functionality.

using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Converters;
using DSharpPlus.Entities;

namespace DSPlus.Examples
{
    public class MathOperationConverter : IArgumentConverter<MathOperation>
    {
        public Task<Optional<MathOperation>> ConvertAsync(string value, CommandContext ctx)
        {
            return value switch
            {
                "+" => Task.FromResult(Optional.FromValue(MathOperation.Add)),
                "-" => Task.FromResult(Optional.FromValue(MathOperation.Subtract)),
                "*" => Task.FromResult(Optional.FromValue(MathOperation.Multiply)),
                "/" => Task.FromResult(Optional.FromValue(MathOperation.Divide)),
                "%" => Task.FromResult(Optional.FromValue(MathOperation.Modulo)),
                _ => Task.FromResult(Optional.FromValue(MathOperation.Add))
            };
        }
    }
}
