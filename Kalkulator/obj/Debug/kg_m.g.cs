﻿#pragma checksum "..\..\kg_m.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DB00F318478C70F40C1A6BA63AB379A3D2FC0A6"
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
    /// kg_m
    /// </summary>
    public partial class kg_m : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeightText;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeightT;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeightText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeightT;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCalculate;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bmiTextBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock comTextBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\kg_m.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BMITextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Kalkulator;component/kg_m.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\kg_m.xaml"
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
            this.WBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\kg_m.xaml"
            this.WBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\kg_m.xaml"
            this.HBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WeightText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.WeightT = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.HeightText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.HeightT = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ButtonCalculate = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\kg_m.xaml"
            this.ButtonCalculate.Click += new System.Windows.RoutedEventHandler(this.ButtonCalculate_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bmiTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.comTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BMITextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

