/*
 * (c) 2012 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using System;
using System.IO;
using Mosa.Compiler.Common;
using Mosa.Compiler.Framework;
using Mosa.Compiler.Framework.Operands;
using Mosa.Compiler.Linker;
using Mosa.Compiler.Metadata;
using Mosa.Compiler.Platform.Common;

namespace Mosa.Platform.AVR32
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseTransformationStage : BasePlatformTransformationStage
	{

		#region Data members

		protected DataConverter Converter = DataConverter.LittleEndian;

		#endregion // Data members

		#region IPipelineStage Members

		/// <summary>
		/// Retrieves the name of the compilation stage.
		/// </summary>
		/// <value>The name of the compilation stage.</value>
		public override string Name { get { return "AVR32." + this.GetType().Name; } }

		#endregion // IPipelineStage Members

		#region Emit Methods

		#endregion // Emit Methods

	}
}