﻿#pragma checksum "..\..\Window2_PaymentInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB0F5F9826DC22B55AE2A9E192E5628611DEC51D94DD8AD7A2EFAB9A8D71A1BA"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Window2_PaymentInformation
    /// </summary>
    public partial class Window2_PaymentInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatientFullName_PaymentInf;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Policlinic_PaymentInf;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Doctor_PaymentInf;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Service_PaymentInf;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateTime_PaymentInf;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FinalSum;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Window2_PaymentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Payment;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/window2_paymentinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window2_PaymentInformation.xaml"
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
            this.PatientFullName_PaymentInf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Policlinic_PaymentInf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Doctor_PaymentInf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Service_PaymentInf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DateTime_PaymentInf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FinalSum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Payment = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Window2_PaymentInformation.xaml"
            this.Payment.Click += new System.Windows.RoutedEventHandler(this.ToPay);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
