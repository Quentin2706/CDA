﻿#pragma checksum "..\..\action.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DCFA884D409620C9DCD4D65A50918ED878B08EB54CD0F0B2C653883A157E998"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using gestionProduit;


namespace gestionProduit {
    
    
    /// <summary>
    /// action
    /// </summary>
    public partial class action : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labTitre;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labIdProduit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labLibelleProduit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labCategorie;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labRayon;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAction;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuler;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxIdProduit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxLibelleProduit;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxCategorie;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\action.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxRayon;
        
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
            System.Uri resourceLocater = new System.Uri("/gestionProduit;component/action.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\action.xaml"
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
            this.labTitre = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labIdProduit = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labLibelleProduit = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labCategorie = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labRayon = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnAction = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\action.xaml"
            this.btnAction.Click += new System.Windows.RoutedEventHandler(this.btnAction_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\action.xaml"
            this.btnAnnuler.Click += new System.Windows.RoutedEventHandler(this.btnRetour_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbxIdProduit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbxLibelleProduit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbxCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.tbxRayon = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

