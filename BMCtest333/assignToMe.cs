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
    ///The assignToMe recording.
    /// </summary>
    [TestModule("ede887c8-007a-4939-bbfe-2d232d3b785a", ModuleType.Recording, 1)]
    public partial class AssignToMe : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static AssignToMe instance = new AssignToMe();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AssignToMe()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AssignToMe Instance
        {
            get { return instance; }
        }

#region Variables

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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.btn_assignToMe' at 24;10.", repo.IncidentForm.btn_assignToMeInfo, new RecordItemIndex(0));
            repo.IncidentForm.btn_assignToMe.Click("24;10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.NextStage' at 30;1.", repo.IncidentForm.NextStageInfo, new RecordItemIndex(1));
            repo.IncidentForm.NextStage.Click("30;1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BMCRemedySearch.FormContainer.False' at 30;14.", repo.BMCRemedySearch.FormContainer.FalseInfo, new RecordItemIndex(2));
            repo.BMCRemedySearch.FormContainer.False.Click("30;14");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '.' with focus on 'BMCRemedySearch.FormContainer.False'.", repo.BMCRemedySearch.FormContainer.FalseInfo, new RecordItemIndex(3));
            repo.BMCRemedySearch.FormContainer.False.PressKeys(".");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.btn_save_NextStage_PopUp' at 32;2.", repo.IncidentForm.btn_save_NextStage_PopUpInfo, new RecordItemIndex(4));
            repo.IncidentForm.btn_save_NextStage_PopUp.Click("32;2");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}