﻿#pragma checksum "..\..\WindowWydaj.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9AC16ADDE78371C8B059516DDDCAED20161D46C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using TorKartingowy;


namespace TorKartingowy {
    
    
    /// <summary>
    /// WindowWydaj
    /// </summary>
    public partial class WindowWydaj : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumerKartyKierowcy;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypBiletu;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypKartu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Kart;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Czas;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowWydaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DoZaplaty;
        
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
            System.Uri resourceLocater = new System.Uri("/TorKartingowy;component/windowwydaj.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowWydaj.xaml"
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
            this.NumerKartyKierowcy = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\WindowWydaj.xaml"
            this.NumerKartyKierowcy.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TypBiletu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.TypKartu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Kart = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Czas = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\WindowWydaj.xaml"
            this.Czas.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DoZaplaty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 24 "..\..\WindowWydaj.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_WydajBilet);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

