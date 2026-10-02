using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using CLient.ViewModels;

namespace CLient;

public class ViewLocator : IDataTemplate
{
  public Control? Build(object? data)
  {
    if (data is null) return null;

    // Skapa en View(Sida)
    var viewName = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
    var view = Type.GetType(viewName);

    if (view is null) return null;

    var control = (Control)Activator.CreateInstance(view);
    control.DataContext = data;

    return control;
  }

  public bool Match(object? data) => data is ViewModelBase;

}
