// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// StoreFloatR8
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class StoreFloatR8 : BaseIRInstruction
	{
		public StoreFloatR8()
			: base(3, 0)
		{
		}

		public override bool HasSideEffect { get { return true; } }
	}
}

