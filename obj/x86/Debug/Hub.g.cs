﻿#pragma checksum "D:\DSI\DSI\Hub.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5753B718E3BA7F31CB97965E7CE84B4703EF1C051D2F797EFD633630DD1FF739"
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
    partial class Hub : 
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
            case 2: // Hub.xaml line 40
                {
                    this.ReturnToMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ReturnToMenu).Click += this.ReturnToMenu_Click;
                }
                break;
            case 3: // Hub.xaml line 61
                {
                    this.RobotTeam = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RobotTeam).Click += this.RobotTeam_Click;
                }
                break;
            case 4: // Hub.xaml line 82
                {
                    this.Settings = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Settings).Click += this.Settings_Click;
                }
                break;
            case 5: // Hub.xaml line 104
                {
                    this.Level1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Level1).Click += this.Level1_Click;
                }
                break;
            case 6: // Hub.xaml line 105
                {
                    this.Level2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Hub.xaml line 106
                {
                    this.Level3 = (global::Windows.UI.Xaml.Controls.Button)(target);
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

