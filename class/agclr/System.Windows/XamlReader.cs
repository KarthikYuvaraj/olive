//
// XamlReader.cs: this is a reader that wraps Ian McCoy's Xaml Reader
// that he wrote for the Google Summer of Code 2005 and exposes the
// API required in Silverlight.
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

using Mono;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using Mono.Xaml;

namespace System.Windows {
	
	public static class XamlReader {
	
		static XamlReader () {
		}

		public static DependencyObject Load (string xaml)
		{
			DependencyObject.Ping ();
			return Load (xaml, false);
		}
		
		public static DependencyObject Load (string xaml, bool createNamescope)
		{
			if (xaml == null)
				throw new ArgumentNullException ("xaml");

			DependencyObject.Ping ();
			Kind kind;
			ManagedXamlLoader loader = new ManagedXamlLoader ();
			loader.CreateNativeLoader (null, xaml);
			IntPtr top = NativeMethods.xaml_create_from_str (loader.NativeLoader, xaml, createNamescope, out kind);
			loader.FreeNativeLoader ();
			
			if (top == IntPtr.Zero)
				return null;

			DependencyObject result = DependencyObject.Lookup (kind, top);
			
			if (result != null) {
				// Delete our reference, result already has one.
				NativeMethods.base_unref (top);
			}
			
			return result;
		}
	}
}
