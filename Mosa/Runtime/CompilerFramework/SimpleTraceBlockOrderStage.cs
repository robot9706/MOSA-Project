/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mosa.Runtime.CompilerFramework
{
	/// <summary>
	/// The Simple Trace Block Order Stage reorders Blocks to optimize loops and reduce the distance of jumps and branches.
	/// </summary>
	public class SimpleTraceBlockOrderStage : IMethodCompilerStage, IBasicBlockOrder
	{
		#region Data members

		/// <summary>
		/// 
		/// </summary>
		protected IArchitecture arch;
		/// <summary>
		/// 
		/// </summary>
		protected List<BasicBlock> blocks;
		/// <summary>
		/// 
		/// </summary>
		protected BasicBlock firstBlock;
		/// <summary>
		/// 
		/// </summary>
		protected int[] orderedBlocks;

		#endregion // Data members

		#region Properties

		/// <summary>
		/// Retrieves the name of the compilation stage.
		/// </summary>
		/// <value>The name of the compilation stage.</value>
		public string Name
		{
			get { return @"Simple Trace Block Order"; }
		}

		/// <summary>
		/// Gets the ordered Blocks.
		/// </summary>
		/// <value>The ordered Blocks.</value>
		public int[] OrderedBlocks { get { return orderedBlocks; } }

		#endregion // Properties

		#region IMethodCompilerStage Members

		/// <summary>
		/// Runs the specified compiler.
		/// </summary>
		/// <param name="compiler">The compiler.</param>
		public void Run(IMethodCompiler compiler)
		{
			// Retrieve the basic block provider
			IBasicBlockProvider blockProvider = (IBasicBlockProvider)compiler.GetPreviousStage(typeof(IBasicBlockProvider));

			if (blockProvider == null)
				throw new InvalidOperationException(@"Simple Trace Block Order stage requires basic Blocks.");

			blocks = blockProvider.Blocks;

			// Retreive the first block
			firstBlock = blockProvider.FromLabel(-1);

			// Determines the block order
			DetermineBlockOrder();
		}

		/// <summary>
		/// Determines the block order.
		/// </summary>
		private void DetermineBlockOrder()
		{
			// Create bit array of refereced Blocks (by index)
			BitArray referencedBlocks = new BitArray(blocks.Count, false);

			// Allocate list of ordered Blocks
			orderedBlocks = new int[blocks.Count];
			int orderBlockCnt = 0;

			// Create sorted worklist
			Stack<BasicBlock> workList = new Stack<BasicBlock>();

			// Start worklist with first block
			workList.Push(firstBlock);

			while (workList.Count != 0) {
				BasicBlock block = workList.Pop();

				if (!referencedBlocks.Get(block.Index)) {

					referencedBlocks.Set(block.Index, true);
					orderedBlocks[orderBlockCnt++] = block.Index;

					foreach (BasicBlock successor in block.NextBlocks)
						if (!referencedBlocks.Get(successor.Index))
							workList.Push(successor);
				}
			}

			// Place unreferenced Blocks at the end of the list
			for (int i = 0; i < blocks.Count; i++)
				if (!referencedBlocks.Get(i))
					orderedBlocks[orderBlockCnt++] = i;
		}

		/// <summary>
		/// Adds to pipeline.
		/// </summary>
		/// <param name="pipeline">The pipeline.</param>
		public void AddToPipeline(CompilerPipeline<IMethodCompilerStage> pipeline)
		{
			pipeline.InsertBefore<IL.CilToIrTransformationStage>(this);
		}

		#endregion // Methods
	}
}
