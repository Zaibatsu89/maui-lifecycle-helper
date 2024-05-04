# MAUI lifecycle helper

## Support
Support for Zaibatsu89 maui-lifecycle-helper ended on **May 4, 2024**.

Zaibatsu89 maui-lifecycle-helper is succeeded by [Plugin MAUI lifecycle helper][plugin-maui-lifecycle-helper-repo] as described by template [Plugin MAUI feature][plugin-maui-feature-repo].

To all our developers and contributors, thank you so much for being a part of our community. We'll see you all over in [Plugin MAUI lifecycle helper][plugin-maui-lifecycle-helper-repo]!

[plugin-maui-lifecycle-helper-repo]:https://github.com/Zaibatsu89/Plugin.Maui.LifecycleHelper/
[plugin-maui-feature-repo]:https://github.com/jfversluis/Plugin.Maui.Feature/

## About
Helps MAUI developers implement lifecycle triggers in Pages of Shell, NavigationPage or TabbedPage.

## Setup
```
public App : Application
{
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        return Zaibatsu89.MauiLifecycleHelper.Manager.Init(window, MainPage);
    }
}
```

## Usage
```
using Zaibatsu89.MauiLifecycleHelper;

public MyPage : ContentPage, IPageActivated, IPageDeactivated
{
    public void OnActivated()
    {
        // the app is activated
        // after being deactivated
    }

    public void OnDeactivated()
    {
        // the app is deactivated
        // after being activated
    }
}
```

## Changelog
- Version 1.0.1
    - Updated "Microsoft.Maui.Controls"
- Version 1.0.0
