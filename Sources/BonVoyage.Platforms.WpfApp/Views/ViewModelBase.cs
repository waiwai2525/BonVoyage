using System;
using System.Reactive.Disposables;
using Prism.Mvvm;

namespace BonVoyage.Platforms.WpfApp.Views;

public class ViewModelBase : BindableBase, IDisposable
{
    protected CompositeDisposable Disposable { get; } = new();

    public void Dispose()
    {
        Disposable.Dispose();
        GC.SuppressFinalize(this);
    }
}
