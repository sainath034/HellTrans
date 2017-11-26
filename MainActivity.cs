using Android.App;
using Android.Widget;
using Android.OS;

namespace HellTrans
{
    [Activity(Label = "HellTrans", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            EditText AccountNumberText = FindViewById<EditText>(Resource.Id.txtAccountNumber);
            EditText IFSCCodeText = FindViewById<EditText>(Resource.Id.txtIFSCCode);
            Button SaveButton = FindViewById<Button>(Resource.Id.btnSave);
            Button ResetButton = FindViewById<Button>(Resource.Id.btnReset);
            Button CancelButton = FindViewById<Button>(Resource.Id.btnCancel);

            ResetButton.Click += (sender, e) =>
            {
                AccountNumberText.Text = string.Empty;
                IFSCCodeText.Text = string.Empty;
            };
        }
    }
}

