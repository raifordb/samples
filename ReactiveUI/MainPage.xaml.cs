﻿//    THIS SAMPLE CODE IS PROVIDED FOR THE PURPOSE OF ILLUSTRATION ONLY
//    AND IS NOT INTENDED TO BE USED IN A PRODUCTION ENVIRONMENT.

//    THIS SAMPLE CODE AND ANY RELATED INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY
//    OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//    IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ReactiveUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            DataContext = new MainViewModel()
            {
                IsDownloading = false,
                Uri = ""
            };

            this.InitializeComponent();
        }

        private void OnBindImage(object sender, TappedRoutedEventArgs e)
        {
            MainViewModel mvm = DataContext as MainViewModel;
            mvm.IsDownloading = true;
            mvm.Uri = tbUrl.Text;
        }

        private void OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MainViewModel mvm = DataContext as MainViewModel;
            mvm.IsDownloading = false;

            // TODO: it is possible to bind to a local error image for better feedback
        }

        private void OnImageOpened(object sender, RoutedEventArgs e)
        {
            MainViewModel mvm = DataContext as MainViewModel;
            mvm.IsDownloading = false;
        }
    }

}
