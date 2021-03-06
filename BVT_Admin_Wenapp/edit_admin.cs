﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace BVT_Admin_Wenapp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The edit_admin recording.
    /// </summary>
    [TestModule("44f12600-36b6-4d35-ae94-64c37f4ad1c5", ModuleType.Recording, 1)]
    public partial class edit_admin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BVT_Admin_WebappRepository repository.
        /// </summary>
        public static BVT_Admin_WebappRepository repo = BVT_Admin_WebappRepository.Instance;

        static edit_admin instance = new edit_admin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public edit_admin()
        {
            email = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static edit_admin Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable url.
        /// </summary>
        [TestVariable("0349e901-4169-4b6d-8d82-bb2facc1de58")]
        public string url
        {
            get { return repo.url; }
            set { repo.url = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable email.
        /// </summary>
        [TestVariable("42977186-fe6a-4bbb-8977-ce6e3b7b1861")]
        public string email
        {
            get { return repo.email; }
            set { repo.email = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Move item 'AdminWebapp.User' at Center.", repo.AdminWebapp.UserInfo, new RecordItemIndex(0));
                repo.AdminWebapp.User.MoveTo();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(1));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.AdminUser' at Center.", repo.AdminWebapp.AdminUserInfo, new RecordItemIndex(2));
                repo.AdminWebapp.AdminUser.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(3));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(4));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuEmailAddress' at Center.", repo.AdminWebapp.SearchMenuEmailAddressInfo, new RecordItemIndex(5));
                repo.AdminWebapp.SearchMenuEmailAddress.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$email' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(6));
                repo.AdminWebapp.Root.Text.PressKeys(email);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(7));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(8));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(9));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.Ranorex51888AtmailinatorCom1' at Center.", repo.AdminWebapp.Root.Ranorex51888AtmailinatorCom1Info, new RecordItemIndex(10));
                repo.AdminWebapp.Root.Ranorex51888AtmailinatorCom1.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.Edit1' at Center.", repo.AdminWebapp.Root.Edit1Info, new RecordItemIndex(11));
                repo.AdminWebapp.Root.Edit1.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.FormControlSelectBorderSelectNewSe1' at Center.", repo.AdminWebapp.Root.FormControlSelectBorderSelectNewSe1Info, new RecordItemIndex(12));
                repo.AdminWebapp.Root.FormControlSelectBorderSelectNewSe1.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='div') on item 'AdminWebapp1.Root.BreadcrumbWraper'.", repo.AdminWebapp1.Root.BreadcrumbWraperInfo, new RecordItemIndex(13));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.BreadcrumbWraperInfo, "TagName", "div", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='div') on item 'AdminWebapp1.Root.HeadContainer'.", repo.AdminWebapp1.Root.HeadContainerInfo, new RecordItemIndex(14));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.HeadContainerInfo, "TagName", "div", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='div') on item 'AdminWebapp2.PanelBody'.", repo.AdminWebapp2.PanelBodyInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.AdminWebapp2.PanelBodyInfo, "TagName", "div", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='div') on item 'AdminWebapp2.PanelBody1'.", repo.AdminWebapp2.PanelBody1Info, new RecordItemIndex(16));
                Validate.AttributeEqual(repo.AdminWebapp2.PanelBody1Info, "TagName", "div", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.DisableUser'.", repo.AdminWebapp1.Root.DisableUserInfo, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.DisableUserInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.DeleteUser'.", repo.AdminWebapp1.Root.DeleteUserInfo, new RecordItemIndex(18));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.DeleteUserInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.DisableMFA'.", repo.AdminWebapp1.Root.DisableMFAInfo, new RecordItemIndex(19));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.DisableMFAInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(19)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.ResetMFA'.", repo.AdminWebapp1.Root.ResetMFAInfo, new RecordItemIndex(20));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.ResetMFAInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='button') on item 'AdminWebapp1.Button'.", repo.AdminWebapp1.ButtonInfo, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.AdminWebapp1.ButtonInfo, "TagName", "button", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.Cancel'.", repo.AdminWebapp1.Root.CancelInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.CancelInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(23));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(24));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            try {
                Key_sequence();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(26));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            try {
                Key_sequence1();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(28));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.UpdateUser' at Center.", repo.AdminWebapp.UpdateUserInfo, new RecordItemIndex(29));
                repo.AdminWebapp.UpdateUser.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(30));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(30)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(31));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Confirm' at Center.", repo.AdminWebapp.ConfirmInfo, new RecordItemIndex(32));
                repo.AdminWebapp.Confirm.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(32)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (InnerText>'User Updated') on item 'AdminWebapp.UserUpdated'.", repo.AdminWebapp.UserUpdatedInfo, new RecordItemIndex(33));
                Validate.AttributeContains(repo.AdminWebapp.UserUpdatedInfo, "InnerText", "User Updated", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(33)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(34));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(35));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuEmailAddress' at Center.", repo.AdminWebapp.SearchMenuEmailAddressInfo, new RecordItemIndex(36));
                repo.AdminWebapp.SearchMenuEmailAddress.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(36)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$email' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(37));
                repo.AdminWebapp.Root.Text.PressKeys(email);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(37)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(38));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(38)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(39));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(39)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(40));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(40)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.Ranorex51888AtmailinatorCom1' at Center.", repo.AdminWebapp.Root.Ranorex51888AtmailinatorCom1Info, new RecordItemIndex(41));
                repo.AdminWebapp.Root.Ranorex51888AtmailinatorCom1.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(41)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(42));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(42)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.Edit1' at Center.", repo.AdminWebapp.Root.Edit1Info, new RecordItemIndex(43));
                repo.AdminWebapp.Root.Edit1.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(43)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(44));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(44)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.DisableUser' at Center.", repo.AdminWebapp.DisableUserInfo, new RecordItemIndex(45));
                repo.AdminWebapp.DisableUser.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(45)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(46));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(46)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(47));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(47)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Confirm' at Center.", repo.AdminWebapp.ConfirmInfo, new RecordItemIndex(48));
                repo.AdminWebapp.Confirm.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(48)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (InnerText>'User deactivated success') on item 'AdminWebapp.Root.UserDeactivatedSuccessfully'.", repo.AdminWebapp.Root.UserDeactivatedSuccessfullyInfo, new RecordItemIndex(49));
                Validate.AttributeContains(repo.AdminWebapp.Root.UserDeactivatedSuccessfullyInfo, "InnerText", "User deactivated success", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(49)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(50));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(50)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(51));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(51)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.Ranorex51888AtmailinatorCom' at Center.", repo.AdminWebapp.Root.Ranorex51888AtmailinatorComInfo, new RecordItemIndex(52));
                repo.AdminWebapp.Root.Ranorex51888AtmailinatorCom.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(52)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(53));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(53)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(54));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(54)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Root.ENABLEUSER' at Center.", repo.AdminWebapp.Root.ENABLEUSERInfo, new RecordItemIndex(55));
                repo.AdminWebapp.Root.ENABLEUSER.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(55)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(56));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(56)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(57));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(57)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.Confirm' at Center.", repo.AdminWebapp.ConfirmInfo, new RecordItemIndex(58));
                repo.AdminWebapp.Confirm.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(58)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (InnerText>'User activated successful') on item 'AdminWebapp.Root.UserActivatedSuccessfully'.", repo.AdminWebapp.Root.UserActivatedSuccessfullyInfo, new RecordItemIndex(59));
                Validate.AttributeContains(repo.AdminWebapp.Root.UserActivatedSuccessfullyInfo, "InnerText", "User activated successful", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(59)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Move item 'AdminWebapp.User' at Center.", repo.AdminWebapp.UserInfo, new RecordItemIndex(60));
                repo.AdminWebapp.User.MoveTo();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(60)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(61));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(61)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.AdminUser' at Center.", repo.AdminWebapp.AdminUserInfo, new RecordItemIndex(62));
                repo.AdminWebapp.AdminUser.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(62)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(63));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(63)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
