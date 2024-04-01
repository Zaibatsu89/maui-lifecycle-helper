# MAUI lifecycle helper
Helps MAUI developers implement lifecycle triggers in Pages.

## Setup
```
public App : Application
{
    protected override Window CreateWindow(IActivationState activationState)
    {
        base.CreateWindow(activationState);
        return Zaibatsu89.MauiLifecycleHelper.Init();
    }
}
```

## Usage
```
using Zaibatsu89.MauiLifecycleHelper;

public MyPage : ContentPage, IPage
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
- Version 1.0.1: "Manager"