﻿#pragma checksum "..\..\..\BookRetrievalPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "897464B258C3C17ABEC3D5F7F92B1E9906D1C5D5"
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
    /// BookRetrievalPanel
    /// </summary>
    public partial class BookRetrievalPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxname;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxcateg;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxchar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxauthor;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsearch;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnget;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\BookRetrievalPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnback;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectWPF;component/bookretrievalpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookRetrievalPanel.xaml"
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
            
            #line 8 "..\..\..\BookRetrievalPanel.xaml"
            ((ProjectWPF.BookRetrievalPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dg1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\BookRetrievalPanel.xaml"
            this.dg1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtboxname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtboxcateg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtboxchar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtboxauthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\..\BookRetrievalPanel.xaml"
            this.checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.checkbox_Unchecked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\BookRetrievalPanel.xaml"
            this.checkbox.Checked += new System.Windows.RoutedEventHandler(this.checkbox_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnsearch = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\BookRetrievalPanel.xaml"
            this.btnsearch.Click += new System.Windows.RoutedEventHandler(this.btnsearch_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnget = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\BookRetrievalPanel.xaml"
            this.btnget.Click += new System.Windows.RoutedEventHandler(this.btnget_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnback = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\BookRetrievalPanel.xaml"
            this.btnback.Click += new System.Windows.RoutedEventHandler(this.btnback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
