﻿/*
 * (c) 2015 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Stefan Andres Charsley (charsleysa) <charsleysa@gmail.com>
 */

namespace Mosa.TinyCPUSimulator.x86.Opcodes
{
	public class Pxor : BaseX86Opcode
	{
		public override void Execute(CPUx86 cpu, SimInstruction instruction)
		{
			var a = LoadFloatValue(cpu, instruction.Operand1, instruction.Size);
			var b = LoadFloatValue(cpu, instruction.Operand2, instruction.Size);
			int size = instruction.Size;

			a.ULow = a.ULow ^ b.ULow;
			a.UHigh = a.UHigh ^ b.UHigh;

			StoreFloatValue(cpu, instruction.Operand1, a, size);
		}
	}
}