using Android.App;
using Android.Content;
using Android.OS;
using Application = Android.App.Application;

namespace BambuMan
{
    /// <summary>
    /// Cross NFC (Android specific)
    /// </summary>
    public static partial class CrossNfc
    {
        internal static ActivityLifecycleContextListener? lifecycleListener;

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="application">Android <see cref="Application"/></param>
        public static void Init(Application application)
        {
            if (lifecycleListener != null) return;
            lifecycleListener = new ActivityLifecycleContextListener();
            application.RegisterActivityLifecycleCallbacks(lifecycleListener);
        }

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="activity">Android <see cref="Activity"/></param>
        public static void Init(Activity activity)
        {
            if (activity.Application != null) Init(activity.Application);
            if (lifecycleListener != null) lifecycleListener.Activity = activity;
        }

        /// <summary>
        /// Overrides Activity.OnNewIntent()
        /// </summary>
        /// <param name="intent">Android <see cref="Intent"/></param>
        public static void OnNewIntent(Intent intent) => ((NfcImplementation)Current).HandleNewIntent(intent);

        /// <summary>
        /// Overrides Activity.OnResume()
        /// </summary>
        public static void OnResume() => ((NfcImplementation)Current).HandleOnResume();

        /// <summary>
        /// Returns the current Android <see cref="Context"/>
        /// </summary>
        internal static Context AppContext => Application.Context;

        /// <summary>
        /// Returns the current Android <see cref="Activity"/>
        /// </summary>
        /// <param name="throwError"></param>
        /// <returns></returns>
        internal static Activity? GetCurrentActivity(bool throwError)
        {
            var activity = lifecycleListener?.Activity;
            
            if (throwError && activity == null) throw new NullReferenceException("The current Activity can not be detected. Ensure that you have called Init in your Activity or Application class.");
            
            return activity;
        }
    }

    /// <summary>
    /// James Montemagno's ActivityLifecycleContextListener from CurrentActivityPlugin
    /// <see href="https://github.com/jamesmontemagno/CurrentActivityPlugin"/>
    /// </summary>
    class ActivityLifecycleContextListener : Java.Lang.Object, Application.IActivityLifecycleCallbacks
    {
        private readonly WeakReference<Activity?> currentActivity = new(null);

        internal Context Context => Activity ?? Application.Context;

        internal Activity? Activity
        {
            get => currentActivity.TryGetTarget(out var a) ? a : null;
            set => currentActivity.SetTarget(value);
        }

        void Application.IActivityLifecycleCallbacks.OnActivityCreated(Activity activity, Bundle? savedInstanceState) => Activity = activity;
        void Application.IActivityLifecycleCallbacks.OnActivityDestroyed(Activity activity) { }
        void Application.IActivityLifecycleCallbacks.OnActivityPaused(Activity activity) => Activity = activity;
        void Application.IActivityLifecycleCallbacks.OnActivityResumed(Activity activity) => Activity = activity;
        void Application.IActivityLifecycleCallbacks.OnActivitySaveInstanceState(Activity activity, Bundle outState) { }
        void Application.IActivityLifecycleCallbacks.OnActivityStarted(Activity activity) { }
        void Application.IActivityLifecycleCallbacks.OnActivityStopped(Activity activity) { }
    }
}
