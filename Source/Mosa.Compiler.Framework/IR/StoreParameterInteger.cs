// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// StoreParameterInteger
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class StoreParameterInteger : BaseIRInstruction
	{
		public StoreParameterInteger()
			: base(2, 0)
		{
		}

		public override bool HasSideEffect { get { return true; } }
	}
}

