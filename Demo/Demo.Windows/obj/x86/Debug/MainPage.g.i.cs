﻿

#pragma checksum "c:\users\v-misun\documents\visual studio 2015\Projects\Demo\Demo\Demo.Windows\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCEFF8EEA5288B7B54DDBBC010F27692"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView MasterListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid DetailGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressRing MyProgressRing; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Image DetailImage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock DetailNameTextBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock DetailDescriptionTextBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            MasterListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("MasterListView");
            DetailGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("DetailGrid");
            MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)this.FindName("MyProgressRing");
            DetailImage = (global::Windows.UI.Xaml.Controls.Image)this.FindName("DetailImage");
            DetailNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("DetailNameTextBlock");
            DetailDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("DetailDescriptionTextBlock");
        }
    }
}



