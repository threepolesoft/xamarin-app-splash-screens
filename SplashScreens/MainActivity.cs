using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Lang;
using Exception = System.Exception;

namespace SplashScreens
{
    public class MainActivity : Application
    {
        public Activity Activity;

        public override void OnCreate()
        {
            try
            {
                base.OnCreate();
                new Handler(Looper.MainLooper).Post(new Runnable(FirstRunExcite));
            }
            catch (Exception exception)
            {

            }
        }

        private void FirstRunExcite()
        {
            try
            {
                Intent intent = new Intent(Activity, typeof(Activities.SplashScreenActivity));
                intent.AddCategory(Intent.CategoryHome);
                intent.PutExtra("crash", true);
                intent.SetAction(Intent.ActionMain);
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask | ActivityFlags.ClearTask);


                Activity.Finish();
            }
            catch (Exception exception)
            {
            }
        }
    }
}