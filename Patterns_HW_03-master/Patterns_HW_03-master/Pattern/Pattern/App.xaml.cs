using Pattern.Step;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Pattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            this.Step();
        }
        private void Step()
        {
            ViewFactory factory = new ViewFactory();
            ViewInfrastructure infrastructure = factory.Create();

            infrastructure.View.DataContext = infrastructure.ViewModel;
            infrastructure.View.ShowsNavigationUI();
        }
    }
}
