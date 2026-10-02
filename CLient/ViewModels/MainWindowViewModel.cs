using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CLient.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
  [ObservableProperty]
  private string _pageTitle = "Welcome to RunStore";
}
