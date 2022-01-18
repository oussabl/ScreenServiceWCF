using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

    using System;

namespace Screen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity

       
    {
        private object currentCharacterName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button button = FindViewById<Button>(Resource.Id.idred);
            var buttony = FindViewById<Button>(Resource.Id.idyallow);
            var buttono = FindViewById<Button>(Resource.Id.idother);
            var buttong = FindViewById<Button>(Resource.Id.idgreen);
            var text = FindViewById<TextView>(Resource.Id.txtid);
            var etext = FindViewById<EditText>(Resource.Id.etxt1);
          //  TextView textView = FindViewById<EditText>(Resource.Id.txtv1) ;

          //  button.Click += delegate  { text.Text = "Hello from the button Red" + etext.Text ; };
            buttony.Click += delegate { text.Text = "Hello from the button Yellow "; };
            buttono.Click += delegate { text.Text = "Hello from the button Other"; };
            buttong.Click += delegate { ToastNotification.TostMessage("Hello From pop"); };

              localhost.Service client = new localhost.Service();

              //String result = "" + etext.Text;
              String aa = client.GetData("oussama");


                button.Click += delegate { text.Text =  aa; };
            

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}