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

namespace POC_WinCalculator
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyResult recording.
    /// </summary>
    [TestModule("2da5cb2a-0859-4c70-8063-02e69fae2304", ModuleType.Recording, 1)]
    public partial class VerifyResult : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POC_WinCalculatorRepository repository.
        /// </summary>
        public static POC_WinCalculatorRepository repo = POC_WinCalculatorRepository.Instance;

        static VerifyResult instance = new VerifyResult();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyResult()
        {
            result = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyResult Instance
        {
            get { return instance; }
        }

#region Variables

        string _result;

        /// <summary>
        /// Gets or sets the value of variable result.
        /// </summary>
        [TestVariable("3f3ef15c-e8ac-408f-9b92-18761b34fce8")]
        public string result
        {
            get { return _result; }
            set { _result = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$result) on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Text", result);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}