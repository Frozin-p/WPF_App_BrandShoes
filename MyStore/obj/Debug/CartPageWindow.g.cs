﻿#pragma checksum "..\..\CartPageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D681E61F870AC6938D01D1DEDC4714C44BD257387BDFB6DFAA71EB22B381909C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MyStore;
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


namespace MyStore {
    
    
    /// <summary>
    /// CartPageWindow
    /// </summary>
    public partial class CartPageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\CartPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Account;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CartPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cart;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CartPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Favourites;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\CartPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyStore;component/cartpagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CartPageWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Account = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\CartPageWindow.xaml"
            this.Account.Click += new System.Windows.RoutedEventHandler(this.UserPage_Button);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Cart = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CartPageWindow.xaml"
            this.Cart.Click += new System.Windows.RoutedEventHandler(this.Cart_Button);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Favourites = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\CartPageWindow.xaml"
            this.Favourites.Click += new System.Windows.RoutedEventHandler(this.Favourites_Button);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Home = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\CartPageWindow.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Page_Button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

