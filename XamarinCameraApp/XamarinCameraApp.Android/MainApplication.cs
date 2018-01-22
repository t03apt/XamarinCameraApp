using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Plugin.CurrentActivity;

namespace XamarinCameraApp.Droid
{
    [Application]
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
          : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            SetCurrentActivity(activity);
        }

        public void OnActivityDestroyed(Activity activity)
        {
        }

        public void OnActivityPaused(Activity activity)
        {
        }

        public void OnActivityResumed(Activity activity)
        {
            SetCurrentActivity(activity);
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted(Activity activity)
        {
            SetCurrentActivity(activity);
        }

        public void OnActivityStopped(Activity activity)
        {
        }

        private void SetCurrentActivity(Activity activity)
        {
            CrossCurrentActivity.Current.Activity = activity;
        }
    }
}