﻿#pragma checksum "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F20CFDCDE94600BFB7584A4ABBB6D02EF0B005E9DDBCDC1CC54057BEECF549DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using exel_app_new.pages_app.ofline_mode;


namespace exel_app_new.pages_app.ofline_mode {
    
    
    /// <summary>
    /// ofline_main_page
    /// </summary>
    public partial class ofline_main_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ofline;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_xml;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grbData;
        
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
            System.Uri resourceLocater = new System.Uri("/exel_app_new;component/pages_app/ofline_mode/ofline_main_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
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
            this.btn_ofline = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            this.btn_ofline.Click += new System.Windows.RoutedEventHandler(this.btn_ofline_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_exel = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            this.btn_exel.Click += new System.Windows.RoutedEventHandler(this.btn_exel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_edit_xml = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            this.btn_edit_xml.Click += new System.Windows.RoutedEventHandler(this.btn_edit_xml_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grbData = ((System.Windows.Controls.DataGrid)(target));
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
            switch (connectionId)
            {
            case 6:
            
            #line 30 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_upd_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 37 "..\..\..\..\pages_app\ofline_mode\ofline_main_page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_del_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
