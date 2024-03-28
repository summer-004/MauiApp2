using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private LinearLayout main;
        private Button closeBtn;
        private Button showBtn;
        private Button clsBtn;
        private EditText editTxt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.layout1);

            main = FindViewById<LinearLayout>(Resource.Id.mainLayout);
            closeBtn = FindViewById<Button>(Resource.Id.close);
            showBtn = FindViewById<Button>(Resource.Id.show);
            clsBtn = FindViewById<Button>(Resource.Id.cls);
            editTxt = FindViewById<EditText>(Resource.Id.editTxt);
            showBtn.Click += ShowBtn_Click;
            //Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            char[] types = { 's', 'c'};
            Random rnd=new Random();
            var a = $"img{rnd.Next(1, 2)}{types[rnd.Next(1)]}";
            main.RemoveAllViews();
            //int imgToShow = int.Parse(editTxt.Text);
            LinearLayout layout = new LinearLayout(this);
            var imgv = new ImageView(this);

            imgv.SetImageResource(Resources.GetIdentifier("img2c", "drawable", this.PackageName));

            imgv.LayoutParameters = new LinearLayout.LayoutParams(0, 200, 1);
            layout.AddView(imgv);
            

            main.AddView(layout);
        }

        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    MenuInflater.Inflate(Resource.Menu.menu_main, menu);
        //    return true;
        //}

        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    int id = item.ItemId;
        //    if (id == Resource.Id.action_settings)
        //    {
        //        return true;
        //    }

        //    return base.OnOptionsItemSelected(item);
        //}

        //private void FabOnClick(object sender, EventArgs eventArgs)
        //{
        //    View view = (View) sender;
        //    Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
        //        .SetAction("Action", (View.IOnClickListener)null).Show();
        //}

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
