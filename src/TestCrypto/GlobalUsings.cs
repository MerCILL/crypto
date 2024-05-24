// .NET
global using System.Windows;
global using System.Net.Http;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using System.Runtime.CompilerServices;
global using System.Globalization;
global using System.Diagnostics;

// Third-party
global using Newtonsoft.Json;
global using AutoMapper;

// UI 
global using System.Windows.Input;
global using System.Windows.Data;
global using System.Windows.Controls;
global using System.Windows.Navigation;
global using System.Windows.Controls.Primitives;

// Additional
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.DependencyInjection;

// Project
global using TestCrypto.Infrastructure.Responses;
global using TestCrypto.Infrastructure.Abstractions;
global using TestCrypto.Infrastructure.Helpers.Abstractions;
global using TestCrypto.Infrastructure.Helpers.CoinGecko;
global using TestCrypto.Infrastructure.Helpers;
global using TestCrypto.Infrastructure.Repositories;
global using TestCrypto.Models;
global using TestCrypto.Application.Abstractions;
global using TestCrypto.Application;
global using TestCrypto.Application.Mappers;
global using TestCrypto.Application.Services;
global using TestCrypto.Presentation.ViewModels;
global using TestCrypto.Presentation.Views;