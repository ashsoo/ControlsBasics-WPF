//------------------------------------------------------------------------------
// <copyright file="Tours.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System.Windows.Controls;
    using Microsoft.Samples.Kinect.ControlsBasics;
    using Microsoft.Samples.Kinect.ControlsBasics.DataModel;

    /// <summary>
    /// Interaction logic for Tours
    /// </summary>
    public partial class Tours : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tours"/> class.
        /// </summary>
        public Tours()
        {
            this.InitializeComponent();
            var sampleDataSource = SampleDataSource.GetGroup("Group-1");
            var obj = App.Current as App;
            this.zomimage.Source = obj.imgz;
        }
    }
}
