﻿#pragma checksum "..\..\crearTrabajadores.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD743C822E012428E0838C085A324B30CA4D9B9F027D7D82F2459F86F4C3BADD"
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
    /// crearTrabajadores
    /// </summary>
    public partial class crearTrabajadores : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRut;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellido;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCelular;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrarTrabajador;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\crearTrabajadores.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
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
            System.Uri resourceLocater = new System.Uri("/SAFE.Presentacion;component/creartrabajadores.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\crearTrabajadores.xaml"
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
            this.txtRut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCelular = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnRegistrarTrabajador = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\crearTrabajadores.xaml"
            this.btnRegistrarTrabajador.Click += new System.Windows.RoutedEventHandler(this.btnRegistrarTrabajador_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\crearTrabajadores.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

