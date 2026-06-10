using System;
using System.Windows.Forms;

namespace Practice11_12_13_CalculatorLayout;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
