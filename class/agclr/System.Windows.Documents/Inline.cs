//
// System.Windows.Documents.Inline.cs
//
// Authors:
//	Atsushi Enomoto  <atsushi@ximian.com>
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
using System.Windows;
using Mono;
using System.Windows.Media;

namespace System.Windows.Documents {

	public abstract class Inline : DependencyObject {

		public static readonly DependencyProperty FontFamilyProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "FontFamily", typeof (string));
		public static readonly DependencyProperty FontSizeProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "FontSize", typeof (double));
		public static readonly DependencyProperty FontStretchProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "FontStretch", typeof (FontStretches));
		public static readonly DependencyProperty FontStyleProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "FontStyle", typeof (FontStyles));
		public static readonly DependencyProperty FontWeightProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "FontWeight", typeof (int));
		public static readonly DependencyProperty ForegroundProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "Foreground", typeof (Brush));
		public static readonly DependencyProperty TextDecorationsProperty =
			DependencyProperty.Lookup (Kind.TEXTBLOCK, "TextDecorations", typeof (TextDecorations));

		public Inline ()  : base (NativeMethods.glyphs_new ())
		{
			NativeMethods.base_ref (native);
		}

		internal Inline (IntPtr raw) : base (raw)
		{
		}

		public string FontFamily {
			get { return (string) GetValue (FontFamilyProperty); }
			set { SetValue (FontFamilyProperty, value); }
		}

		public double FontSize {
			get { return (double) GetValue (FontSizeProperty); }
			set { SetValue (FontSizeProperty, value); }
		}

		public FontStretches FontStretch {
			get { return (FontStretches) GetValue (FontStretchProperty); }
			set { SetValue (FontStretchProperty, value); }
		}

		public FontStyles FontStyle {
			get { return (FontStyles) GetValue (FontStyleProperty); }
			set { SetValue (FontStyleProperty, value); }
		}

		public FontWeights FontWeight {
			get { return (FontWeights) GetValue (FontWeightProperty); }
			set { SetValue (FontWeightProperty, value); }
		}

		public Brush Foreground {
			get { return (Brush) GetValue (ForegroundProperty); }
			set { SetValue (ForegroundProperty, value); }
		}

		public TextDecorations TextDecorations {
			get { return (TextDecorations) GetValue (TextDecorationsProperty); }
			set { SetValue (TextDecorationsProperty, value); }
		}

		internal override Kind GetKind ()
		{
			return Kind.INLINE;
		}
	}
}
