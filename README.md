# MAUI lifecycle helper
Helps MAUI developers implement lifecycle triggers in Pages of NavigationPage.

## Setup
```
public App : Application
{
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        return Zaibatsu89.MauiLifecycleHelper.Manager.Init(window, (NavigationPage)MainPage);
    }
}
```

## Usage
```
using Zaibatsu89.MauiLifecycleHelper;

public MyPage : ContentPage, IPageActivated, IPageDeactivated
{
    public OnActivated()
    {
        // the app is activated
        // after being deactivated
    }

    public OnDeactivated()
    {
        // the app is deactivated
        // after being activated
    }
}
```

## Changelog
- Version 1.0.3: "IPageActivated, IPageDeactivated, ..."
- Version 1.0.2: "Setup"
- Version 1.0.1: "Manager"