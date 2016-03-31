//------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using Microsoft.Kinect.Wpf.Controls;
using System.Windows;
using System.Windows.Media;

    /// <summary>
    /// Interaction logic for App
    /// </summary>
    public partial class App : Application
    {
        internal KinectRegion KinectRegion { get; set; }
        public ImageSource imgz { get; set; }
    }
}
