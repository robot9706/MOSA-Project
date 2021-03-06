// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// CompareIntBranch32
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class CompareIntBranch32 : BaseIRInstruction
	{
		public override int ID { get { return 27; } }

		public CompareIntBranch32()
			: base(0, 2)
		{
		}

		public override FlowControl FlowControl { get { return FlowControl.ConditionalBranch; } }
	}
}
