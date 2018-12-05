// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// MovStore16
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class MovStore16 : X64Instruction
	{
		public override int ID { get { return 457; } }

		internal MovStore16()
			: base(0, 3)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 0);
			System.Diagnostics.Debug.Assert(node.OperandCount == 3);

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 5) && node.Operand2.IsConstantZero && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.AppendByte(0x00);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 5) && node.Operand2.IsCPURegister && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand2.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.AppendByte(0x00);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && node.Operand2.IsConstantZero && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && (node.Operand2.IsConstant && node.Operand2.ConstantSignedInteger >= -128 && node.Operand2.ConstantSignedInteger <= 127) && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && node.Operand2.IsConstant && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b10);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsCPURegister && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand2.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsConstantZero && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				return;
			}

			if (node.Operand1.IsCPURegister && (node.Operand2.IsConstant && node.Operand2.ConstantSignedInteger >= -128 && node.Operand2.ConstantSignedInteger <= 127) && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsConstant && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b10);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append32BitImmediate(node.Operand2);
				return;
			}

			if (node.Operand1.IsConstant && node.Operand2.IsConstantZero && node.Operand3.IsCPURegister)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0x89);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand3.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.Append32BitImmediate(node.Operand1);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 5) && node.Operand2.IsConstantZero && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.AppendByte(0x00);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 5) && node.Operand2.IsCPURegister && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand2.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.AppendByte(0x00);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && node.Operand2.IsConstantZero && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && (node.Operand2.IsConstant && node.Operand2.ConstantSignedInteger >= -128 && node.Operand2.ConstantSignedInteger <= 127) && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if ((node.Operand1.IsCPURegister && node.Operand1.Register.RegisterCode == 4) && node.Operand2.IsConstant && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b10);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				emitter.OpcodeEncoder.Append32BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsCPURegister && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b100);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(node.Operand2.Register.RegisterCode);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsConstantZero && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsCPURegister && (node.Operand2.IsConstant && node.Operand2.ConstantSignedInteger >= -128 && node.Operand2.ConstantSignedInteger <= 127) && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b01);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsCPURegister && node.Operand2.IsConstant && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b10);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
				emitter.OpcodeEncoder.Append32BitImmediate(node.Operand2);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsConstant && node.Operand2.IsConstantZero && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.Append32BitImmediate(node.Operand1);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsConstant && node.Operand2.IsConstant && node.Operand3.IsConstant)
			{
				emitter.OpcodeEncoder.AppendByte(0x66);
				emitter.OpcodeEncoder.AppendByte(0xC7);
				emitter.OpcodeEncoder.Append2Bits(0b00);
				emitter.OpcodeEncoder.Append3Bits(0b000);
				emitter.OpcodeEncoder.Append3Bits(0b101);
				emitter.OpcodeEncoder.Append32BitImmediateWithOffset(node.Operand1, node.Operand2);
				emitter.OpcodeEncoder.Append16BitImmediate(node.Operand3);
				return;
			}

			if (node.Operand1.IsConstant && node.Operand2.IsConstant && node.Operand3.IsCPURegister)
			{
				return;
			}

			throw new Compiler.Common.Exceptions.CompilerException("Invalid Opcode");
		}
	}
}
