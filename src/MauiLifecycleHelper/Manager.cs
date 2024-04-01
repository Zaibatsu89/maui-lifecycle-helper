namespace Zaibatsu89.MauiLifecycleHelper
{
    public static class Manager
    {
        public static Window Init(Window window, NavigationPage navigation)
        {
            window.Created += (s, e) =>
            {
                if (navigation.CurrentPage is IPageCreated page)
                {
                    page.OnCreated();
                }
            };

            window.Resumed += (s, e) =>
            {
                if (navigation.CurrentPage is IPageResumed page)
                {
                    page.OnResumed();
                }
            };

            window.Activated += (s, e) =>
            {
                if (navigation.CurrentPage is IPageActivated page)
                {
                    page.OnActivated();
                }
            };

            window.Deactivated += (s, e) =>
            {
                if (navigation.CurrentPage is IPageDeactivated page)
                {
                    page.OnDeactivated();
                }
            };

            window.Stopped += (s, e) =>
            {
                if (navigation.CurrentPage is IPageStopped page)
                {
                    page.OnStopped();
                }
            };

            window.Destroying += (s, e) =>
            {
                if (navigation.CurrentPage is IPageDestroying page)
                {
                    page.OnDestroying();
                }
            };

            window.Backgrounding += (s, e) =>
            {
                if (navigation.CurrentPage is IPageBackgrounding page)
                {
                    page.OnBackgrounding(e.State);
                }
            };

            return window;
        }
    }
}