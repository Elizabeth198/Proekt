﻿#pragma checksum "..\..\..\Pages\Department.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3766B84DF0384FA31437F1C404E8F3F70F5E4A129DAAE9314B2905BC8D24A6D2"
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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// Department
    /// </summary>
    public partial class Department : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition SplitterColumn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ChangeColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDep;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyDep;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditDep;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteDep;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeObjectsFilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeObjectsFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridDep;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/department.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Department.xaml"
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
            
            #line 9 "..\..\..\Pages\Department.xaml"
            ((WpfApp1.Pages.Department)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SplitterColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.ChangeColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.AddDep = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\Department.xaml"
            this.AddDep.Click += new System.Windows.RoutedEventHandler(this.AddDep_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CopyDep = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Department.xaml"
            this.CopyDep.Click += new System.Windows.RoutedEventHandler(this.AddDep_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditDep = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\Department.xaml"
            this.EditDep.Click += new System.Windows.RoutedEventHandler(this.AddDep_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteDep = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\Department.xaml"
            this.DeleteDep.Click += new System.Windows.RoutedEventHandler(this.DeleteDep_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TypeObjectsFilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\Pages\Department.xaml"
            this.TypeObjectsFilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeObjectsFilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TypeObjectsFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Pages\Department.xaml"
            this.TypeObjectsFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TypeObjectsFilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DataGridDep = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 49 "..\..\..\Pages\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseEdChangeClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 54 "..\..\..\Pages\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommitButtonDep);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
