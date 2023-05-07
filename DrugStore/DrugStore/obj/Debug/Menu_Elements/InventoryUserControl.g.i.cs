﻿#pragma checksum "..\..\..\Menu_Elements\InventoryUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B13258224301E86009BFC169EF3C4487FDCB5E35D94049CE687DD474AF301E21"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DrugStore.Menu_Elements;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace DrugStore.Menu_Elements {
    
    
    /// <summary>
    /// InventoryUserControl
    /// </summary>
    public partial class InventoryUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 38 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search_Text;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductCode;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProductType;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPriceOption;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbQuantityOption;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtExpirationDate;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbExpirationOption;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView drugListView;
        
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
            System.Uri resourceLocater = new System.Uri("/DrugStore;component/menu_elements/inventoryusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
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
            this.Search_Text = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.Search_Text.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtProductCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.txtProductCode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtProductCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 64 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Sort_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbProductType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.cmbProductType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbProductType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 97 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.txtPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Price_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbPriceOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 98 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.cmbPriceOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbPriceOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cmbQuantityOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 109 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.cmbQuantityOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbQuantityOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtExpirationDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.cmbExpirationOption = ((System.Windows.Controls.ComboBox)(target));
            
            #line 121 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            this.cmbExpirationOption.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbQuantityOption_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.drugListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 13:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 170 "..\..\..\Menu_Elements\InventoryUserControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListViewItemSelected);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

