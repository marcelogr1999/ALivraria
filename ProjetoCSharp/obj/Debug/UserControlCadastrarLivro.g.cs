﻿#pragma checksum "..\..\UserControlCadastrarLivro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02158E3783064964DB68BA19495BA36EB9195763"
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
using MaterialDesignThemes.Wpf.Transitions;
using ProjetoCSharp;
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


namespace ProjetoCSharp {
    
    
    /// <summary>
    /// UserControlCadastrarLivro
    /// </summary>
    public partial class UserControlCadastrarLivro : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxNomeLivro;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox listGeneros;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxCod;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxValor;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxDescricao;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\UserControlCadastrarLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrar;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetoCSharp;component/usercontrolcadastrarlivro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlCadastrarLivro.xaml"
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
            
            #line 9 "..\..\UserControlCadastrarLivro.xaml"
            ((ProjetoCSharp.UserControlCadastrarLivro)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControlCadastrarLivro_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.boxNomeLivro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.listGeneros = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.boxCod = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.boxValor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.boxDescricao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnCadastrar = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\UserControlCadastrarLivro.xaml"
            this.btnCadastrar.Click += new System.Windows.RoutedEventHandler(this.btnCadastrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

