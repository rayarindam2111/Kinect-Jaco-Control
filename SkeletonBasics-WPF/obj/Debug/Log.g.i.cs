﻿#pragma checksum "..\..\Log.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00627489A81653058DDC2AD7A44DEA44"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Microsoft.Samples.Kinect.SkeletonBasics {
    
    
    /// <summary>
    /// Log
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Log : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\Log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.SkeletonBasics.Log logWindow;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\Log.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstLog;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SkeletonBasics-WPF;component/log.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Log.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.logWindow = ((Microsoft.Samples.Kinect.SkeletonBasics.Log)(target));
            
            #line 4 "..\..\Log.xaml"
            this.logWindow.SizeChanged += new System.Windows.SizeChangedEventHandler(this.logWindow_SizeChanged);
            
            #line default
            #line hidden
            
            #line 4 "..\..\Log.xaml"
            this.logWindow.Closing += new System.ComponentModel.CancelEventHandler(this.logWindow_Closing);
            
            #line default
            #line hidden
            
            #line 4 "..\..\Log.xaml"
            this.logWindow.Loaded += new System.Windows.RoutedEventHandler(this.logWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstLog = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

