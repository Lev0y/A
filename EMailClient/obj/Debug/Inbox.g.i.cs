﻿#pragma checksum "..\..\Inbox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203C4561FFC8771F6141790892425924B0F79895"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EMailClient;
using Microsoft.Windows.Themes;
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


namespace EMailClient {
    
    
    /// <summary>
    /// Page2
    /// </summary>
    public partial class Page2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Inbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bAllMessage;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Inbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDeletedMessage;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Inbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button l20;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Inbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListOfLetters;
        
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
            System.Uri resourceLocater = new System.Uri("/EMailClient;component/inbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Inbox.xaml"
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
            this.bAllMessage = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Inbox.xaml"
            this.bAllMessage.Click += new System.Windows.RoutedEventHandler(this.bAllMessage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bDeletedMessage = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Inbox.xaml"
            this.bDeletedMessage.Click += new System.Windows.RoutedEventHandler(this.bDeletedMessage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.l20 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Inbox.xaml"
            this.l20.Click += new System.Windows.RoutedEventHandler(this.l20_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListOfLetters = ((System.Windows.Controls.ListView)(target));
            
            #line 19 "..\..\Inbox.xaml"
            this.ListOfLetters.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListOfLetters_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

