namespace SplashScreens.Activities;

[Activity(Label = "HomeActivity")]
public class HomeActivity : Activity
{
    private TextView SkipButton;


    protected override void OnCreate(Bundle savedInstanceState)
    {
        try
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.HomeLayout);

        }
        catch (Exception exception)
        {
        }
    }
}