﻿#pragma checksum "C:\Users\Rodrigo\Desktop\DSI\Hub.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32007B01DDEA8DDBCB2E68F907CBF506E3287F8553C10B4A95C25A02114775FE"
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
            case 2: // Hub.xaml line 42
                {
                    this.ReturnToMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ReturnToMenu).Click += this.ReturnToMenu_Click;
                }
                break;
            case 3: // Hub.xaml line 63
                {
                    this.RobotTeam = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RobotTeam).Click += this.RobotTeam_Click;
                }
                break;
            case 4: // Hub.xaml line 84
                {
                    this.Settings = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Settings).Click += this.Settings_Click;
                }
                break;
            case 5: // Hub.xaml line 107
                {
                    this.n1Img = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.n1Img).PointerEntered += this.n1Img_PointerEntered_1;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n1Img).PointerExited += this.n1Img_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n1Img).PointerPressed += this.Level1_Click;
                }
                break;
            case 6: // Hub.xaml line 108
                {
                    this.n2Img = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.n2Img).PointerEntered += this.n2Img_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n2Img).PointerExited += this.n2Img_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n2Img).PointerPressed += this.Level2_Click;
                }
                break;
            case 7: // Hub.xaml line 109
                {
                    this.n3Img = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.n3Img).PointerEntered += this.n3Img_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n3Img).PointerExited += this.n3Img_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n3Img).PointerPressed += this.Level3_Click;
                }
                break;
            case 8: // Hub.xaml line 110
                {
                    this.n4Img = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.n4Img).PointerEntered += this.n4Img_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n4Img).PointerExited += this.n4Img_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Image)this.n4Img).PointerPressed += this.Level4_Click;
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

