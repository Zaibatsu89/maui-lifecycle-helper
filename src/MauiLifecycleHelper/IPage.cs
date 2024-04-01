namespace Zaibatsu89.MauiLifecycleHelper
{
    public interface IPage
    {
        void OnCreated(); // concept: module Lifecycle klasse "Window" functie "OnCreated"
        void OnResumed(); // concept: module Lifecycle klasse "Window" functie "OnResumed"
        void OnActivated(); // concept: module Lifecycle klasse "Window" functie "OnActivated"
        void OnDeactivated(); // concept: module Lifecycle klasse "Window" functie "OnDeactivated"
        void OnStopped(); // concept: module Lifecycle klasse "Window" functie "OnStopped"
        void OnDestroying(); // concept: module Lifecycle klasse "Window" functie "OnDestroying"
        void OnBackgrounding(IPersistedState state); // concept: module Lifecycle klasse "Window" functie "OnBackgrounding"
    }
}