using Android.Content.Res;
using Android.Content;
using Android.OS;
using Android.Telephony.Data;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Graphics;

namespace SplashScreens
{
    public static partial class Config
    {
        public static class Settings
        {

            public static void FullScreen(Activity context, bool setFull = false)
            {
                try
                {

                        if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
                        {
                            //context.Window?.SetDecorFitsSystemWindows(false);

                            context.RequestWindowFeature(WindowFeatures.NoTitle);
                            context.Window?.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

                            //context.Window?.AddFlags(WindowManagerFlags.Fullscreen); 
                        }
                        else if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                        {
                            View mContentView = context.Window?.DecorView;

                            if (mContentView != null)
                            {
#pragma warning disable 618
                                var uiOptions = (int)mContentView.SystemUiVisibility;
#pragma warning restore 618
                                var newUiOptions = uiOptions;

                                newUiOptions |= (int)SystemUiFlags.Fullscreen;
                                newUiOptions |= (int)SystemUiFlags.LayoutStable;
                                //newUiOptions |= (int)SystemUiFlags.HideNavigation;
                                newUiOptions |= (int)SystemUiFlags.LightStatusBar;
#pragma warning disable 618
                                mContentView.SystemUiVisibility = (StatusBarVisibility)newUiOptions;
#pragma warning restore 618
                            }

                            context.Window?.ClearFlags(WindowManagerFlags.TranslucentStatus);
                            context.Window?.AddFlags(WindowManagerFlags.Fullscreen);

                            context.Window?.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                            context.Window?.SetStatusBarColor(Color.Transparent);
                        }
                        else if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
                        {
                            context.Window?.AddFlags(WindowManagerFlags.TranslucentStatus);
                        }
                    
                }
                catch (Exception exception)
                {
                   
                }
            }
        }
    }
}
