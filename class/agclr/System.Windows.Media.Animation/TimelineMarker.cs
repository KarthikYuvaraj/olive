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
using MS.Internal;

namespace System.Windows.Media.Animation
{
	public class TimelineMarker : DependencyObject
	{
		public static readonly DependencyProperty TextProperty = 
			DependencyProperty.Lookup (Kind.TIMELINEMARKER, "Text", typeof (string));
		public static readonly DependencyProperty TimeProperty = 
			DependencyProperty.Lookup (Kind.TIMELINEMARKER, "Time", typeof (TimeSpan));
		public static readonly DependencyProperty TypeProperty = 
			DependencyProperty.Lookup (Kind.TIMELINEMARKER, "Type", typeof (string));
		
		public TimelineMarker() : base (NativeMethods.timeline_marker_new ())
		{
			NativeMethods.base_ref (native);
		}
		
		internal TimelineMarker (IntPtr raw) : base (raw)
		{
		}
		
		internal protected override Kind GetKind ()
		{
			return Kind.TIMELINEMARKER;
		}

		public string Text { 
			get {
				return (string) GetValue (TextProperty);
			}
			set {
				SetValue (TextProperty, value);
			}
		}
		
		public TimeSpan Time { 
			get {
				return (TimeSpan) GetValue (TimeProperty);
			}
			set {
				SetValue (TimeProperty, value); 
			}
		}
		
		public string Type { 
			get {
				return (string) GetValue (TypeProperty);
			}
			set {
				SetValue (TypeProperty, value);
			}
		}
	}
}
