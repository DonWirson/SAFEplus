﻿#pragma checksum "..\..\mantenedorBase.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6BE57B8CA34A56472F078B581EAD48A25ABE7E055601D932FA7FBC6ABB42BE47"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SAFE.Presentacion;
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


namespace SAFE.Presentacion {
    
    
    /// <summary>
    /// mantenedorBase
    /// </summary>
    public partial class mantenedorBase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem txtConsultaClientes;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem txtCrearClientes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem txtConsultaTrabajadores;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem txtRegistroTrabajadores;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgClientes;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\mantenedorBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgTrabajadores;
        
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
            System.Uri resourceLocater = new System.Uri("/SAFE.Presentacion;component/mantenedorbase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mantenedorBase.xaml"
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
            this.txtConsultaClientes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\mantenedorBase.xaml"
            this.txtConsultaClientes.Click += new System.Windows.RoutedEventHandler(this.txtConsultaClientes_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCrearClientes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\mantenedorBase.xaml"
            this.txtCrearClientes.Click += new System.Windows.RoutedEventHandler(this.txtCrearClientes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtConsultaTrabajadores = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\mantenedorBase.xaml"
            this.txtConsultaTrabajadores.Click += new System.Windows.RoutedEventHandler(this.txtConsultaTrabajadores_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtRegistroTrabajadores = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\mantenedorBase.xaml"
            this.txtRegistroTrabajadores.Click += new System.Windows.RoutedEventHandler(this.txtRegistroTrabajadores_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 21 "..\..\mantenedorBase.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dtgClientes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.dtgTrabajadores = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

