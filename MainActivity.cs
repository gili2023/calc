using Android;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using static System.Net.Mime.MediaTypeNames;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        Button btplus, btminos,btdev,btmul;
        TextView tv;
        EditText num1, num2;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btplus = FindViewById<Button>(Resource.Id.button1);
            btminos = FindViewById<Button>(Resource.Id.button2);
            btdev = FindViewById<Button>(Resource.Id.button3);
            btmul = FindViewById<Button>(Resource.Id.button4);
            tv = FindViewById<TextView>(Resource.Id.textView1);
            num1 = FindViewById<EditText>(Resource.Id.editText1);
            num2 = FindViewById<EditText>(Resource.Id.editText2);

            btplus.SetOnClickListener(this);
            btminos.SetOnClickListener(this);

        }

        public void OnClick(View v)
        {
            Button b = (Button)v;


            if (b == btplus)
            {
                int n1 = int.Parse(num1.Text);
                int n2 = int.Parse(num2.Text);

                int res = n1 + n2;
                tv.Text = res.ToString();
            }
            if (b == btminos)
            {
                int n1 = int.Parse(num1.Text);
                int n2 = int.Parse(num2.Text);

                int res = n1 - n2;
                tv.Text = res.ToString();
            }
            if (b == btdev)
            {
                double n1 = double.Parse(num1.Text);
                double n2 = double.Parse(num2.Text);

                double res = n1 / n2;
                tv.Text = res.ToString();
            }
            if (b == btmul)
            {
                int n1 = int.Parse(num1.Text);
                int n2 = int.Parse(num2.Text);

                int res = n1 * n2;
                tv.Text = res.ToString();
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}




