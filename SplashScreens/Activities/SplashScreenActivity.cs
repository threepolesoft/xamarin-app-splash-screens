using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace SplashScreens.Activities;

[Activity(Icon = "@mipmap/appicon", MainLauncher = true, NoHistory = true, Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

public class SplashScreenActivity : Activity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        try
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
                Androidx.Core.Splashscreen.SplashScreen.InstallSplashScreen(this);

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);


            new Handler().PostDelayed(FirstRunExcite, 3000);
        }
        catch (Exception e)
        {
        }
    }

    private void FirstRunExcite()
    {
        try
        {

            StartActivity(new Intent(this, typeof(HomeActivity)));

            Finish();
        }
        catch (Exception exception)
        {

        }
    }
}