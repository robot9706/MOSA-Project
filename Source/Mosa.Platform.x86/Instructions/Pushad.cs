// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Pushad
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed partial class Pushad : X86Instruction
	{
		private static readonly byte[] opcode = new byte[] { 0x60 };

		public Pushad()
			: base(0, 0)
		{
		}

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			emitter.Write(opcode);
		}

		// The following is used by the code automation generator.

		public override byte[] __opcode { get { return opcode; } }
	}
}

