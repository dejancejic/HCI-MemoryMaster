﻿#pragma checksum "..\..\..\..\Pages\AddLevelPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88594A130EC00F9557C2F60BEF1947E935033506"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MemoryMaster.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MemoryMaster.Pages {
    
    
    /// <summary>
    /// AddLevelPage
    /// </summary>
    public partial class AddLevelPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pickImageBtn;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mainMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addLevelBtn;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label levelNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Pages\AddLevelPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ImagesStackPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MemoryMaster;component/pages/addlevelpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddLevelPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\..\..\Pages\AddLevelPage.xaml"
            this.textBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LevelNameTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pickImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Pages\AddLevelPage.xaml"
            this.pickImageBtn.Click += new System.Windows.RoutedEventHandler(this.PickImageBtnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainMenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Pages\AddLevelPage.xaml"
            this.mainMenuBtn.Click += new System.Windows.RoutedEventHandler(this.MainMenuBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addLevelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Pages\AddLevelPage.xaml"
            this.addLevelBtn.Click += new System.Windows.RoutedEventHandler(this.AddLevelBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.levelNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ImagesStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

