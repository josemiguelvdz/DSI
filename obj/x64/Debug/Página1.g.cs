﻿#pragma checksum "C:\Users\Rodrigo\Desktop\DSI\Página1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D890FC83BD92951A96BCD91D715E259CCD918E71128B695178251A26AE2B6301"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P3JoseMiguelVillacanas
{
    partial class Página1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Página1.xaml line 36
                {
                    this.DiamantesTotales = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Página1.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.Image element3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element3).PointerPressed += this.PlayButton_Click;
                }
                break;
            case 4: // Página1.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Image element4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element4).PointerPressed += this.ConfigButton_Click;
                }
                break;
            case 5: // Página1.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.Image element5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element5).PointerPressed += this.BackButton_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

