﻿#pragma checksum "C:\Users\Administrator\Source\Repos\Assignment-1\PhotoLib\PhotoLib\Camera.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E9F90929525BF6C5387612D0F98087C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoLib
{
    partial class Camera : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Camera.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element1 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element1).Click += this.AppBarButton_Click;
                }
                break;
            case 2: // Camera.xaml line 27
                {
                    this.Splitter = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Camera.xaml line 55
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Camera.xaml line 62
                {
                    this.CapturedVideo = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 5: // Camera.xaml line 30
                {
                    this.MediaCenter = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Camera.xaml line 42
                {
                    this.VideoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.VideoButton).Click += this.VideoButton_Click;
                }
                break;
            case 7: // Camera.xaml line 32
                {
                    this.PhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PhotoButton).Click += this.Capture_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
