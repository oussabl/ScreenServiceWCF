using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Screen
{
    public static class ToastNotification
    {
        public static void TostMessage(string message)
        {
            var context = Android.App.Application.Context;
            var tostMessage = message;
            var durtion = ToastLength.Long;


            Toast.MakeText(context, tostMessage, durtion).Show();
        }
    }
}