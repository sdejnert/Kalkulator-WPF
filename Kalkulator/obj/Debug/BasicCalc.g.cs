﻿#pragma checksum "..\..\BasicCalc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7536D705490B403BBADCC255564819ED981F9A63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Kalkulator;
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


namespace Kalkulator {
    
    
    /// <summary>
    /// BasicCalc
    /// </summary>
    public partial class BasicCalc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BattonBack1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CalcTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonPlus;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonMinus;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonMultiplication;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonDivision;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonScore;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BasicCalc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScoreTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Kalkulator;component/basiccalc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BasicCalc.xaml"
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
            this.BattonBack1 = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\BasicCalc.xaml"
            this.BattonBack1.Click += new System.Windows.RoutedEventHandler(this.BattonBack1_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CalcTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\BasicCalc.xaml"
            this.CalcTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButonPlus = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\BasicCalc.xaml"
            this.ButonPlus.Click += new System.Windows.RoutedEventHandler(this.ButonPlus_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButonMinus = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\BasicCalc.xaml"
            this.ButonMinus.Click += new System.Windows.RoutedEventHandler(this.ButonMinus_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButonMultiplication = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\BasicCalc.xaml"
            this.ButonMultiplication.Click += new System.Windows.RoutedEventHandler(this.ButonMultiplication_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButonDivision = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\BasicCalc.xaml"
            this.ButonDivision.Click += new System.Windows.RoutedEventHandler(this.ButonDivision_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonScore = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\BasicCalc.xaml"
            this.ButtonScore.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\BasicCalc.xaml"
            this.ClearButton.Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ScoreTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

