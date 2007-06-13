//
// System.Windows.Media.RadialGradientBrush class
//
// Authors:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
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

namespace System.Windows.Media {

	public class RadialGradientBrush : GradientBrush {

		public static readonly DependencyProperty CenterProperty = DependencyProperty.Lookup (Kind.POINT, "Center", typeof (RadialGradientBrush));
		public static readonly DependencyProperty GradientOriginProperty = DependencyProperty.Lookup (Kind.POINT, "GradientOrigin", typeof (RadialGradientBrush));
		public static readonly DependencyProperty RadiusXProperty = DependencyProperty.Lookup (Kind.POINT, "RadiusX", typeof (RadialGradientBrush));
		public static readonly DependencyProperty RadiusYProperty = DependencyProperty.Lookup (Kind.POINT, "RadiusY", typeof (RadialGradientBrush));


		public RadialGradientBrush ()
		{
		}


		public Point Center {
			get { return (Point) GetValue (CenterProperty); }
			set { SetValue (CenterProperty, value); }
		}

		public Point GradientOrigin {
			get { return (Point) GetValue (GradientOriginProperty); }
			set { SetValue (GradientOriginProperty, value); }
		}

		public double RadiusX {
			get { return (double) GetValue (RadiusXProperty); }
			set { SetValue (RadiusXProperty, value); }
		}

		public double RadiusY {
			get { return (double) GetValue (RadiusYProperty); }
			set { SetValue (RadiusYProperty, value); }
		}
#if false
		protected internal override Kind GetKind ()
		{
			return Kind.RADIALGRADIENTBRUSH;
		}
#endif
	}
}
