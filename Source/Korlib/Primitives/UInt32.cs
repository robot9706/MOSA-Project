﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

namespace System
{
	/// <summary>
	/// 
	/// </summary>
	public struct UInt32
	{
		public const uint MaxValue = 0xffffffff;
		public const uint MinValue = 0;

		internal uint m_value;

		public override string ToString()
		{
			return Int32.CreateString(m_value, false, false);
		}

	}
}