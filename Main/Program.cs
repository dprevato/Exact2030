using Main.Abstractions;
using Main.Services;
using Main.ViewModels;
using Main.Views;
using Microsoft.Extensions.DependencyInjection;
using MvvmGen.Events;
#pragma warning disable CS8604 // Possible null reference argument.

namespace Main;

internal static class Program
{
    public static ServiceProvider? ServiceProvider { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        OnStartup();
        Application.Run(ServiceProvider.GetService<MainWindow>());
    }

    internal static void OnStartup() {
        var sc = new ServiceCollection();

        sc.AddSingleton<IEventAggregator, EventAggregator>();
        sc.AddSingleton<IApplicationUser, ApplicationUser>();
        sc.AddTransient<MainWindow>();
        sc.AddTransient<MainViewModel>();
        sc.AddTransient<PreferencesView>();
        // todo: sc.AddTransient<PreferencesViewModel>();
        sc.AddTransient<PrinterView>();
        // todo: sc.AddTransient<PrinterViewModel>();

        //
        ServiceProvider = sc.BuildServiceProvider(true);
    }
}