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
// Copyright (c) 2007 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//

using System.Windows;
using System.Windows.Input;

namespace System.Windows.Controls {

	public class Control : FrameworkElement {

		protected virtual void OnPreviewMouseDoubleClick (MouseButtonEventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected virtual void OnMouseDoubleClick (MouseButtonEventArgs e)
		{
			throw new NotImplementedException ();
		}

		public static readonly DependencyProperty TemplateProperty =
			DependencyProperty.Register ("Template", typeof (ControlTemplate), typeof (Control),
						     new PropertyMetadata (OnTemplateChanged));
		public ControlTemplate Template {
		    get { return (ControlTemplate)GetValue (TemplateProperty); }
		    set { SetValue (TemplateProperty, value); }
		}
		
		private static void OnTemplateChanged (object sender, DependencyPropertyChangedEventArgs e)
		{
			((Control)sender).OnTemplateChanged ((ControlTemplate)e.OldValue, (ControlTemplate)e.NewValue);
		}

		protected virtual void OnTemplateChanged (ControlTemplate oldTemplate, ControlTemplate newTemplate)
		{
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}

}
