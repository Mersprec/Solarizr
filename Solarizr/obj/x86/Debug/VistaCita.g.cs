﻿#pragma checksum "C:\Users\mespigares\Desktop\Solarizr\Solarizr\VistaCita.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E30B94D8C786AB245FB931C60C8E89E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solarizr
{
    partial class VistaCita : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // VistaCita.xaml line 13
                {
                    this.Panel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3: // VistaCita.xaml line 15
                {
                    this.clientName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // VistaCita.xaml line 16
                {
                    this.clientSurname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // VistaCita.xaml line 17
                {
                    this.clientNumber = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // VistaCita.xaml line 18
                {
                    this.phoneButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7: // VistaCita.xaml line 20
                {
                    this.Date = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // VistaCita.xaml line 22
                {
                    this.clientAddress = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // VistaCita.xaml line 24
                {
                    this.stkImage = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10: // VistaCita.xaml line 50
                {
                    this.Map = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 11: // VistaCita.xaml line 54
                {
                    this.btnMapa = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMapa).Click += this.navegarAlMapa;
                }
                break;
            case 12: // VistaCita.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element12).Click += this.AbrirGaleria;
                }
                break;
            case 13: // VistaCita.xaml line 57
                {
                    this.VisualStateMap = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 14: // VistaCita.xaml line 58
                {
                    this.phone = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 15: // VistaCita.xaml line 74
                {
                    this.tablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

