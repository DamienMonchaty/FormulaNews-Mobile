﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FOne_MobileApp.Droid.Persistence;
using FOne_MobileApp.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

using Environment = System.Environment;
[assembly: Dependency(typeof(SQLiteDb))]
namespace FOne_MobileApp.Droid.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "MySQLite.db");
            return new SQLiteAsyncConnection(path);
        }
    }
}