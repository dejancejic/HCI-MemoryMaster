﻿#pragma checksum "..\..\..\..\Pages\MyLevelsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CED39469CDAA57BC63522C0BA80AEBED682D8A38"
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
    /// MyLevelsPage
    /// </summary>
    public partial class MyLevelsPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mainMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label highScoreLbl;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label resultLbl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label levelNameLbl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label bestTimeLbl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeLeftLbl;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLevels;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\MyLevelsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel levelsStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/MemoryMaster;component/pages/mylevelspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MyLevelsPage.xaml"
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
            
            #line 22 "..\..\..\..\Pages\MyLevelsPage.xaml"
            this.textBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LevelNameTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainMenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\MyLevelsPage.xaml"
            this.mainMenuBtn.Click += new System.Windows.RoutedEventHandler(this.MainMenuBtnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\MyLevelsPage.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.PlayLevelBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.highScoreLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.resultLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.levelNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.bestTimeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.timeLeftLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblLevels = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.levelsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

