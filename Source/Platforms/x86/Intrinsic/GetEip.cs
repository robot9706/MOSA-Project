﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Simon Wollwage (rootnode) <kintaro@think-in-co.de>
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using Mosa.Runtime;
using Mosa.Runtime.CompilerFramework;
using Mosa.Runtime.CompilerFramework.Operands;
using Mosa.Runtime.Vm;
using Mosa.Runtime.Metadata;
using Mosa.Runtime.Metadata.Signatures;
using CIL = Mosa.Runtime.CompilerFramework.CIL;
using IR = Mosa.Runtime.CompilerFramework.IR;

namespace Mosa.Platforms.x86.Intrinsic
{
    public sealed class GetEip : IIntrinsicMethod
    {
        #region Methods

        /// <summary>
        /// Replaces the instrinsic call site
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="typeSystem">The type system.</param>
        public void ReplaceIntrinsicCall(Context context, ITypeSystem typeSystem)
        {
            Operand result = context.Result;
            SigType u4 = new SigType(CilElementType.U4);
            context.SetInstruction(CPUx86.Instruction.MovInstruction, new RegisterOperand(u4, GeneralPurposeRegister.EAX), context.Operand1);
            context.AppendInstruction(CPUx86.Instruction.AddInstruction, new RegisterOperand(u4, GeneralPurposeRegister.EAX), new RegisterOperand(u4, GeneralPurposeRegister.ESP));
            context.AppendInstruction(CPUx86.Instruction.MovInstruction, new RegisterOperand(u4, GeneralPurposeRegister.EAX), new MemoryOperand(u4, GeneralPurposeRegister.EAX, new IntPtr(0)));
            context.AppendInstruction(CPUx86.Instruction.MovInstruction, result, new RegisterOperand(u4, GeneralPurposeRegister.EAX));
        }

        #endregion // Methods
    }
}