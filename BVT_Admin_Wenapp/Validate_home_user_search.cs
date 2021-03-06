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
    ///The Validate_home_user_search recording.
    /// </summary>
    [TestModule("08a128c5-6f8a-426e-856d-1b3f1e2774fc", ModuleType.Recording, 1)]
    public partial class Validate_home_user_search : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BVT_Admin_WebappRepository repository.
        /// </summary>
        public static BVT_Admin_WebappRepository repo = BVT_Admin_WebappRepository.Instance;

        static Validate_home_user_search instance = new Validate_home_user_search();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_home_user_search()
        {
            fname = "";
            lname = "";
            email = "";
            phone = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_home_user_search Instance
        {
            get { return instance; }
        }

#region Variables

        string _fname;

        /// <summary>
        /// Gets or sets the value of variable fname.
        /// </summary>
        [TestVariable("fe932875-b0aa-4559-8f37-4160eaf8e3eb")]
        public string fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        string _lname;

        /// <summary>
        /// Gets or sets the value of variable lname.
        /// </summary>
        [TestVariable("cc18ed29-b01b-446f-8ac3-52ebd1b12514")]
        public string lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        string _phone;

        /// <summary>
        /// Gets or sets the value of variable phone.
        /// </summary>
        [TestVariable("f6226df5-fb48-44a8-9724-f5266cd07b21")]
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

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
        [TestVariable("6d720f7a-db7b-4d25-9aca-c247b0316d78")]
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
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(1));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.HomeUser' at Center.", repo.AdminWebapp.HomeUserInfo, new RecordItemIndex(2));
                repo.AdminWebapp.HomeUser.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(3));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(4));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(5));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.HomeUsers'.", repo.AdminWebapp1.Root.HomeUsersInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.HomeUsersInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='button') on item 'AdminWebapp1.SearchMenuDropdown'.", repo.AdminWebapp1.SearchMenuDropdownInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.AdminWebapp1.SearchMenuDropdownInfo, "TagName", "button", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='input') on item 'AdminWebapp1.Root.Text'.", repo.AdminWebapp1.Root.TextInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.TextInfo, "TagName", "input", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='th') on item 'AdminWebapp1.TdThProp'.", repo.AdminWebapp1.TdThPropInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.AdminWebapp1.TdThPropInfo, "TagName", "th", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.LastName'.", repo.AdminWebapp1.LastNameInfo, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.AdminWebapp1.LastNameInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.EmailAddress'.", repo.AdminWebapp1.Root.EmailAddressInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.EmailAddressInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='span') on item 'AdminWebapp1.Root.PrimaryPhone'.", repo.AdminWebapp1.Root.PrimaryPhoneInfo, new RecordItemIndex(12));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.PrimaryPhoneInfo, "TagName", "span", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuFirstName' at Center.", repo.AdminWebapp.SearchMenuFirstNameInfo, new RecordItemIndex(13));
                repo.AdminWebapp.SearchMenuFirstName.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$fname' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(14));
                repo.AdminWebapp.Root.Text.PressKeys(fname);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(15));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(16));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(17));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(18));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Ctrl+R' Press.", new RecordItemIndex(19));
                Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(19)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s to exist. Associated repository item: 'AdminWebapp.SearchMenuDropdown'", repo.AdminWebapp.SearchMenuDropdownInfo, new ActionTimeout(5000), new RecordItemIndex(20));
                //repo.AdminWebapp.SearchMenuDropdownInfo.WaitForExists(5000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(21));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(22));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuLastName' at Center.", repo.AdminWebapp.SearchMenuLastNameInfo, new RecordItemIndex(23));
                repo.AdminWebapp.SearchMenuLastName.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$lname' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(24));
                repo.AdminWebapp.Root.Text.PressKeys(lname);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(25));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(26));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(27));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(28));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Ctrl+R' Press.", new RecordItemIndex(29));
                Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(30));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(30)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(31));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuEmailAddress' at Center.", repo.AdminWebapp.SearchMenuEmailAddressInfo, new RecordItemIndex(32));
                repo.AdminWebapp.SearchMenuEmailAddress.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(32)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$email' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(33));
                repo.AdminWebapp.Root.Text.PressKeys(email);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(33)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(34));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(35));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(36));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(36)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(37));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(37)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Ctrl+R' Press.", new RecordItemIndex(38));
                Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(38)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(39));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(39)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuDropdown' at Center.", repo.AdminWebapp.SearchMenuDropdownInfo, new RecordItemIndex(40));
                repo.AdminWebapp.SearchMenuDropdown.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(40)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'AdminWebapp.SearchMenuPrimaryPhone' at Center.", repo.AdminWebapp.SearchMenuPrimaryPhoneInfo, new RecordItemIndex(41));
                repo.AdminWebapp.SearchMenuPrimaryPhone.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(41)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$phone' with focus on 'AdminWebapp.Root.Text'.", repo.AdminWebapp.Root.TextInfo, new RecordItemIndex(42));
                repo.AdminWebapp.Root.Text.PressKeys(phone);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(42)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(43));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(43)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Enter' Press.", new RecordItemIndex(44));
                Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(44)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(45));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(45)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(46));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(46)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Ctrl+R' Press.", new RecordItemIndex(47));
                Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(47)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(48));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(48)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagName='ul') on item 'AdminWebapp1.Root.DropdownMenu2'.", repo.AdminWebapp1.Root.DropdownMenu2Info, new RecordItemIndex(49));
                Validate.AttributeEqual(repo.AdminWebapp1.Root.DropdownMenu2Info, "TagName", "ul", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(49)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
