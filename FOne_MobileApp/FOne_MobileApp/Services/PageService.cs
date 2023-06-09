﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FOne_MobileApp.Services
{
    public class PageService : IPageService
    {
        public async Task PushAsync(Page page)
        {
            await MainPage.Navigation.PushModalAsync(page);
        }

        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task DisplayAlert(string title, string message, string ok)
        {
            await MainPage.DisplayAlert(title, message, ok);
        }

        public async Task<Page> PopAsync()
        {
            return await MainPage.Navigation.PopModalAsync();
        }

        private Page MainPage
        {
            get { return Application.Current.MainPage; }
        }
    }
}
