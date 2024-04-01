namespace Zaibatsu89.MauiLifecycleHelper
{
    public static class Manager
    {
        public static Window Init<T>(Window window, T navigation)
        {
            window.Created += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageCreated page)
                {
                    page.OnCreated();
                }
            };

            window.Resumed += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageResumed page)
                {
                    page.OnResumed();
                }
            };

            window.Activated += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageActivated page)
                {
                    page.OnActivated();
                }
            };

            window.Deactivated += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageDeactivated page)
                {
                    page.OnDeactivated();
                }
            };

            window.Stopped += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageStopped page)
                {
                    page.OnStopped();
                }
            };

            window.Destroying += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageDestroying page)
                {
                    page.OnDestroying();
                }
            };

            window.Backgrounding += (s, e) =>
            {
                if (CurrentPage(navigation) is IPageBackgrounding page)
                {
                    page.OnBackgrounding(e.State);
                }
            };

            return window;
        }

        private static Page? CurrentPage<T>(T navigation)
        {
            if (navigation is Shell s)
            {
                return s.CurrentPage;
            }
            else if (navigation is NavigationPage np)
            {
                return np.CurrentPage;
            }
            else if (navigation is TabbedPage tp)
            {
                return tp.CurrentPage;
            }

            return null;
        }
    }
}