﻿#pragma checksum "..\..\..\AdminPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EBAA06F418F76818A2578DC329C8E063AC56BEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProjectWPF {
    
    
    /// <summary>
    /// AdminPanel
    /// </summary>
    public partial class AdminPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblLogged;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnadd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnshow;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btntook;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnaccept;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnlogout;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsettings;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnrebate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjectWPF;component/adminpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\AdminPanel.xaml"
            ((ProjectWPF.AdminPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblLogged = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnadd = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\AdminPanel.xaml"
            this.btnadd.Click += new System.Windows.RoutedEventHandler(this.btnadd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnshow = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\AdminPanel.xaml"
            this.btnshow.Click += new System.Windows.RoutedEventHandler(this.btnshow_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btntook = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AdminPanel.xaml"
            this.btntook.Click += new System.Windows.RoutedEventHandler(this.btntook_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnaccept = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\AdminPanel.xaml"
            this.btnaccept.Click += new System.Windows.RoutedEventHandler(this.btnaccept_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnlogout = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\AdminPanel.xaml"
            this.btnlogout.Click += new System.Windows.RoutedEventHandler(this.btnlogout_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.btnsettings = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\AdminPanel.xaml"
            this.btnsettings.Click += new System.Windows.RoutedEventHandler(this.btnsettings_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnrebate = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\AdminPanel.xaml"
            this.btnrebate.Click += new System.Windows.RoutedEventHandler(this.btnrebate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

