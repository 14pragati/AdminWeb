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
    ///The To_verify_admin_web_dashboard_items recording.
    /// </summary>
    [TestModule("f0d53aab-7c7f-4cfb-a02f-80afdf18c181", ModuleType.Recording, 1)]
    public partial class To_verify_admin_web_dashboard_items : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BVT_Admin_WebappRepository repository.
        /// </summary>
        public static BVT_Admin_WebappRepository repo = BVT_Admin_WebappRepository.Instance;

        static To_verify_admin_web_dashboard_items instance = new To_verify_admin_web_dashboard_items();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public To_verify_admin_web_dashboard_items()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static To_verify_admin_web_dashboard_items Instance
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

            try {
                Validate_AdminUsers(repo.AdminWebapp.Root.AdminUsersInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Validate_SuperAdminUsers(repo.AdminWebapp.Root.SuperAdminUsersInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Validate_SupportUsers(repo.AdminWebapp.Root.SupportUsersInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Validate_DealerUsers(repo.AdminWebapp.Root.DealerUsersInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Validate_HomeUsers(repo.AdminWebapp.Root.HomeUsersInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Validate_IntelliSync(repo.AdminWebapp.Root.IntelliSyncInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Validate_Intelliflo3(repo.AdminWebapp.Root.Intelliflo3Info);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Validate_Gateway(repo.AdminWebapp.Root.GatewayInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Validate_IntelliDrive(repo.AdminWebapp.Root.IntelliDriveInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Validate_Intelliconnect(repo.AdminWebapp.Root.IntelliconnectInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Validate_BackupSumpPump(repo.AdminWebapp.Root.BackupSumpPumpInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Validate_TriLarm(repo.AdminWebapp.Root.TriLarmInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'AdminWebapp2.WellDefender'.", repo.AdminWebapp2.WellDefenderInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.AdminWebapp2.WellDefenderInfo, "TagName", "span");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'AdminWebapp2.SumpController'.", repo.AdminWebapp2.SumpControllerInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.AdminWebapp2.SumpControllerInfo, "TagName", "span");
            Delay.Milliseconds(0);
            
            try {
                Validate_SaltSensor(repo.AdminWebapp.Root.SaltSensorInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Validate_ChemCheck(repo.AdminWebapp.Root.ChemCheckInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Validate_WaterSoftener(repo.AdminWebapp.Root.WaterSoftenerInfo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "", repo.AdminWebapp.Screenshots, false, new RecordItemIndex(17));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}