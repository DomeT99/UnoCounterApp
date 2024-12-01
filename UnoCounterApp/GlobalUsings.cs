﻿global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using UnoCounterApp.Models;
global using UnoCounterApp.Presentation;
global using UnoCounterApp.DataContracts;
global using UnoCounterApp.DataContracts.Serialization;
global using UnoCounterApp.Services.Caching;
global using UnoCounterApp.Services.Endpoints;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;

[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]