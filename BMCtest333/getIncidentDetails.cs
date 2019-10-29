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

namespace BMCtest333
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The getIncidentDetails recording.
    /// </summary>
    [TestModule("c315e65f-c4c7-4669-bcb0-0a869556f2f0", ModuleType.Recording, 1)]
    public partial class getIncidentDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static getIncidentDetails instance = new getIncidentDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public getIncidentDetails()
        {
            var_Status = "";
            var_StatusReason = "";
            var2_StatusReason = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static getIncidentDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _var_Status;

        /// <summary>
        /// Gets or sets the value of variable var_Status.
        /// </summary>
        [TestVariable("48f50358-36bf-4c39-9cf4-877e3adeb6dd")]
        public string var_Status
        {
            get { return _var_Status; }
            set { _var_Status = value; }
        }

        string _var_StatusReason;

        /// <summary>
        /// Gets or sets the value of variable var_StatusReason.
        /// </summary>
        [TestVariable("7545dd5e-0316-4e1c-afea-fbbeb8a2152b")]
        public string var_StatusReason
        {
            get { return _var_StatusReason; }
            set { _var_StatusReason = value; }
        }

        string _var2_StatusReason;

        /// <summary>
        /// Gets or sets the value of variable var2_StatusReason.
        /// </summary>
        [TestVariable("8c0a54fb-b2e9-46f3-ab90-cbc4949d9dc9")]
        public string var2_StatusReason
        {
            get { return _var2_StatusReason; }
            set { _var2_StatusReason = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'IncidentForm.mn_status' and assigning its value to variable 'var_Status'.", repo.IncidentForm.mn_statusInfo, new RecordItemIndex(0));
            var_Status = repo.IncidentForm.mn_status.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'IncidentForm.mn_statusReason' and assigning its value to variable 'var2_StatusReason'.", repo.IncidentForm.mn_statusReasonInfo, new RecordItemIndex(1));
            var2_StatusReason = repo.IncidentForm.mn_statusReason.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
