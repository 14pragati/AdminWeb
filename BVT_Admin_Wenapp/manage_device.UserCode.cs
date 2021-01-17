﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace BVT_Admin_Wenapp
{
    public partial class manage_device
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Report_Screenshot_Screenshots4(RepoItemInfo bodytagInfo)
        {
            Report.Screenshot(ReportLevel.Info, "User", "", bodytagInfo.FindAdapter<BodyTag>(), false);
        }

        public void DoDelay9()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }

        public void Key_shortcut4()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }

        public void Key_sequence_Text4(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$device_type' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(device_type);
        }

        public void Mouse_Click_SearchMenuDeviceType(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo);
            atagInfo.FindAdapter<ATag>().Click();
        }

        public void DoDelay8()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.");
            Delay.Duration(2000, false);
        }

        public void Mouse_Click_SearchMenuDropdown4(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at Center.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click();
        }

        public void Report_Screenshot_Screenshots3(RepoItemInfo bodytagInfo)
        {
            Report.Screenshot(ReportLevel.Info, "User", "", bodytagInfo.FindAdapter<BodyTag>(), false);
        }

        public void DoDelay7()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }

        public void Key_shortcut3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }

        public void Key_sequence_Text3(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$device_id' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(device_id);
        }

        public void Mouse_Click_SearchMenuDeviceID(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo);
            atagInfo.FindAdapter<ATag>().Click();
        }

        public void DoDelay6()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.");
            Delay.Duration(2000, false);
        }

        public void Mouse_Click_SearchMenuDropdown3(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at Center.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click();
        }

        public void Report_Screenshot_Screenshots2(RepoItemInfo bodytagInfo)
        {
            Report.Screenshot(ReportLevel.Info, "User", "", bodytagInfo.FindAdapter<BodyTag>(), false);
        }

        public void DoDelay5()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }

        public void Key_shortcut2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }

        public void Key_sequence_Text2(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$search_email' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(search_email);
        }

        public void Mouse_Click_SearchMenuEmailAddress(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo);
            atagInfo.FindAdapter<ATag>().Click();
        }

        public void DoDelay4()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.");
            Delay.Duration(2000, false);
        }

        public void Mouse_Click_SearchMenuDropdown2(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at Center.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click();
        }

        public void Report_Screenshot_Screenshots1(RepoItemInfo bodytagInfo)
        {
            Report.Screenshot(ReportLevel.Info, "User", "", bodytagInfo.FindAdapter<BodyTag>(), false);
        }

        public void DoDelay3()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }

        public void Key_shortcut1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }

        public void Key_sequence_Text1(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$lname' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(lname);
        }

        public void Mouse_Click_SearchMenuLastName(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo);
            atagInfo.FindAdapter<ATag>().Click();
        }

        public void DoDelay2()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.");
            Delay.Duration(2000, false);
        }

        public void Mouse_Click_SearchMenuDropdown1(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at Center.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click();
        }

        public void Report_Screenshot_Screenshots(RepoItemInfo bodytagInfo)
        {
            Report.Screenshot(ReportLevel.Info, "User", "", bodytagInfo.FindAdapter<BodyTag>(), false);
        }

        public void DoDelay1()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }

        public void Key_shortcut()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        }

        public void Key_sequence_Text(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$fname' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(fname);
        }

        public void Mouse_Click_SearchMenuFirstName(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo);
            atagInfo.FindAdapter<ATag>().Click();
        }

        public void DoDelay()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.");
            Delay.Duration(2000, false);
        }

        public void Mouse_Click_SearchMenuDropdown(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at Center.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click();
        }

        public void Mouse_Click_ManageDevices(RepoItemInfo litagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'litagInfo' at Center.", litagInfo);
            litagInfo.FindAdapter<LiTag>().Click();
        }

    }
}