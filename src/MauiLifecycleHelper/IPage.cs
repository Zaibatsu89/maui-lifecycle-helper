namespace Zaibatsu89.MauiLifecycleHelper
{
    public interface IPage : IPageCreated, IPageResumed, IPageActivated, IPageDeactivated, IPageStopped, IPageDestroying, IPageBackgrounding
    {
        
    }
}