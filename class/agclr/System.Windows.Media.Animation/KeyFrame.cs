// Author:
//   Rolf Bjarne Kvinge  (RKvinge@novell.com)
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

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Input;
using System.Runtime.InteropServices;
using Mono;

namespace System.Windows.Media.Animation
{
	public abstract class KeyFrame : DependencyObject
	{
		
		public static readonly DependencyProperty KeyTimeProperty = DependencyProperty.Lookup (Kind.KEYFRAME, "KeyTime", typeof (KeyFrame));
		
		public KeyFrame() : base (NativeMethods.key_frame_new ())
		{
		}
		
		internal KeyFrame (IntPtr raw) : base (raw)
		{
		}

		public KeyTime KeyTime { 
			get {
				return (KeyTime) GetValue (KeyTimeProperty);
			}
			set {
				SetValue (KeyTimeProperty, value);
			}
		}

		internal protected override Kind GetKind ()
		{
			return Kind.KEYFRAME;
		}
	}
}
