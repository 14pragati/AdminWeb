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
    ///The newsmarketing recording.
    /// </summary>
    [TestModule("578387f6-3c00-4214-bfa3-9a41c4a64a85", ModuleType.Recording, 1)]
    public partial class newsmarketing : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BVT_Admin_WebappRepository repository.
        /// </summary>
        public static BVT_Admin_WebappRepository repo = BVT_Admin_WebappRepository.Instance;

        static newsmarketing instance = new newsmarketing();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public newsmarketing()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static newsmarketing Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AdminWebapp.NewsMarketing1' at Center.", repo.AdminWebapp.NewsMarketing1Info, new RecordItemIndex(0));
            repo.AdminWebapp.NewsMarketing1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(1));
            Delay.Duration(20000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Pro Dealer Admin' on item 'AdminWebapp.Root.UserType'.", repo.AdminWebapp.Root.UserTypeInfo, new RecordItemIndex(3));
            repo.AdminWebapp.Root.UserType.Element.SetAttributeValue("TagValue", "Pro Dealer Admin");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(4));
            Delay.Duration(20000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pro Dealer Admin') on item 'AdminWebapp.ProDealerAdmin'.", repo.AdminWebapp.ProDealerAdminInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.AdminWebapp.ProDealerAdminInfo, "InnerText", "Pro Dealer Admin");
            //Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Pro Dealer Employee' on item 'AdminWebapp.Root.UserType'.", repo.AdminWebapp.Root.UserTypeInfo, new RecordItemIndex(7));
            repo.AdminWebapp.Root.UserType.Element.SetAttributeValue("TagValue", "Pro Dealer Employee");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(8));
            Delay.Duration(20000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Independent Dealer' on item 'AdminWebapp.Root.UserType'.", repo.AdminWebapp.Root.UserTypeInfo, new RecordItemIndex(10));
            repo.AdminWebapp.Root.UserType.Element.SetAttributeValue("TagValue", "Independent Dealer");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(11));
            Delay.Duration(20000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(12));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
