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
    ///The Select1stNumber recording.
    /// </summary>
    [TestModule("ba2cefa3-578b-45bc-875e-7b97dc0d0e52", ModuleType.Recording, 1)]
    public partial class EnterNumber1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POC_WinCalculatorRepository repository.
        /// </summary>
        public static POC_WinCalculatorRepository repo = POC_WinCalculatorRepository.Instance;

        static EnterNumber1 instance = new EnterNumber1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterNumber1()
        {
            num1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterNumber1 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable num1.
        /// </summary>
        [TestVariable("838d704e-b353-4fa2-97e5-0b7f9c013489")]
        public string num1
        {
            get { return repo.num1; }
            set { repo.num1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Num_1' at Center.", repo.Calculator.Num_1Info, new RecordItemIndex(0));
            repo.Calculator.Num_1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
