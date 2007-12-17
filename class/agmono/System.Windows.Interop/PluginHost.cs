//
// BrowserHost.cs
//
// Author:
//   Miguel de Icaza (miguel@novell.com)
//
// Copyright 2007 Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Windows.Interop {

	/// <summary>
	///   This class is used to keep track of the Mozilla plugin handle
	/// </summary>
	/// <remarks>
	///   A number of methods that interact with the browser host require
	///   the plugin handle that was used to create the plugin on the Mozilla
	///   side.   We keep this information here.
	///
	///   This class is static, but since we create a new AppDomain for each
	///   Silverlight surface created on the plugin, the plugin_handle is
	///   actually a per-Silverlight instance variable. 
	/// </remarks>
	public static class PluginHost {
		static IntPtr plugin_handle;

		public static void SetPluginHandle (IntPtr value)
		{
			plugin_handle = value;
		}

		public static IntPtr Handle {
			get {
				return plugin_handle;
			}
		}
	}
}
