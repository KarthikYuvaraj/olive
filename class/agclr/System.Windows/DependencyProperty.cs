//
// DependencyProperty.cs
//
// Author:
//   Iain McCoy (iain@mccoy.id.au)
//   Miguel de Icaza (miguel@novell.com)
// 
//
// Copyright 2005 Iain McCoy
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

namespace System.Windows {
	public class DependencyProperty {
		internal IntPtr native;
		
		public DependencyProperty ()
		{
			// useless constructor.
		}

		internal DependencyProperty (IntPtr handle)
		{
			native = handle;
		}
		
		internal static DependencyProperty Lookup (Value.Kind type, string name)
		{
			IntPtr handle = NativeMethods.dependency_property_lookup (type, name);

			if (handle == IntPtr.Zero)
				return null;

			return new DependencyProperty (handle);
		}

		internal static DependencyProperty Register (string name, Type propertyType, Type ownerType)
		{
			Console.WriteLine ("This way of registering properties is no longer supported:");
			Console.WriteLine ("owner={0} {1} of type {2}", ownerType, name, propertyType);

			return null;
		}
	}
}
