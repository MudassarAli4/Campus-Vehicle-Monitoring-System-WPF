﻿#pragma checksum "..\..\..\bus_register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9EFCD20505C2DB41D64EC912479BAF173943127C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using p2;


namespace p2 {
    
    
    /// <summary>
    /// bus_register
    /// </summary>
    public partial class bus_register : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\bus_register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVehicleName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\bus_register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVehicleOwner;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\bus_register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVehicleType;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\bus_register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNoPlate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\bus_register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mygrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/p2;component/bus_register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\bus_register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtVehicleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtVehicleOwner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtVehicleType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNoPlate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 26 "..\..\..\bus_register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_btn);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\..\bus_register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.del_btn);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 28 "..\..\..\bus_register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.update_btn);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mygrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\bus_register.xaml"
            this.mygrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.mygrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

