﻿#pragma checksum "..\..\BestProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56824FC2C69EDD47EC3915CC8C3D13D58E24FDC72B8D9A44E290FAF6A3B10B98"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// BestProduct
    /// </summary>
    public partial class BestProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\BestProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BestProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TopButtton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\BestProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CatalogButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BestProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FavoriteButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\BestProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasketButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/bestproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BestProduct.xaml"
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
            this.MainButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\BestProduct.xaml"
            this.MainButton.Click += new System.Windows.RoutedEventHandler(this.MainButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopButtton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\BestProduct.xaml"
            this.TopButtton.Click += new System.Windows.RoutedEventHandler(this.TopButtton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CatalogButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\BestProduct.xaml"
            this.CatalogButton.Click += new System.Windows.RoutedEventHandler(this.CatalogButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FavoriteButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\BestProduct.xaml"
            this.FavoriteButton.Click += new System.Windows.RoutedEventHandler(this.FavoriteButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BasketButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\BestProduct.xaml"
            this.BasketButton.Click += new System.Windows.RoutedEventHandler(this.BasketButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

