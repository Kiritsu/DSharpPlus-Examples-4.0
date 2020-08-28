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
// This is a WPF example. It shows how to use WPF without deadlocks.

using System.Diagnostics;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;

namespace DSPlus.Examples
{
    // this class holds the bot itself
    // this is simply used as a sort of container to keep the code organized
    // and partially separated from the UI logic
    public class Bot
    {
        // the client instance, this is initialized with the class
        public DiscordClient Client { get; }

        // this instantiates the container class and the client
        public Bot(string token)
        {
            // create config from the supplied token
            var cfg = new DiscordConfiguration
            {
                Token = token,                   // use the supplied token
                TokenType = TokenType.Bot,       // log in as a bot

                AutoReconnect = true,            // reconnect automatically
                MinimumLogLevel = LogLevel.Debug,
            };

            // initialize the client
            this.Client = new DiscordClient(cfg);
        }

        // this method logs in and starts the client
        public Task StartAsync()
            => this.Client.ConnectAsync();

        // this method logs out and stops the client
        public Task StopAsync()
            => this.Client.DisconnectAsync();
    }
}
