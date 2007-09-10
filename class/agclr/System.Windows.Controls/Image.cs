//
// System.Windows.Controls.Image
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
using System.Windows;
using Mono;

namespace System.Windows.Controls {

	public sealed class Image : MediaBase {

		public static readonly DependencyProperty DownloadProgressProperty =
			DependencyProperty.Lookup (Kind.IMAGE, "DownloadProgress", typeof (double));


		public Image ()  : base (NativeMethods.image_new ())
		{
			NativeMethods.base_ref (native);
		}

		internal Image (IntPtr raw) : base (raw)
		{
		}

		public double DownloadProgress {
			get { return (double) GetValue (DownloadProgressProperty); }
			set { SetValue (DownloadProgressProperty, value); }
		}

		public void SetSource (DependencyObject Downloader, string PartName)
		{
			if (Downloader == null)
				throw new ArgumentNullException ("Downloader");

			Downloader dl = Downloader as Downloader;
			if (dl == null)
				throw new ArgumentException ("Downloader");
			
			if (dl.Status != 200){
				dl.Completed += delegate {
					NativeMethods.image_set_source (native, dl.native, PartName);
				};
				dl.Send ();
			} else {
				NativeMethods.image_set_source (native, dl.native, PartName);
			}
		}

		static object ImageFailedEvent = new object ();

		public event ErrorEventHandler ImageFailed {
			add {
				if (events[ImageFailedEvent] == null)
					Events.AddHandler (this, "ImageFailed", image_failed);
				events.AddHandler (ImageFailedEvent, value);
			}
			remove {
				if (events[ImageFailedEvent] == null)
					Events.AddHandler (this, "ImageFailed", image_failed);
				events.AddHandler (ImageFailedEvent, value);
			}
		}

		static UnmanagedEventHandler image_failed = new UnmanagedEventHandler (image_failed_cb);

		private static void image_failed_cb (IntPtr target, IntPtr calldata, IntPtr closure) {
			// XXX we need to marshal calldata to an ErrorEventArgs struct
			((Image) Helper.GCHandleFromIntPtr (closure).Target).InvokeImageFailed (/* XXX and pass it here*/);
		}

		private void InvokeImageFailed (/* XXX ErrorEventArgs args */)
		{
			EventHandler h = (EventHandler)events[ImageFailedEvent]; // XXX should be ErrorEventHandler
			if (h != null) h (this, EventArgs.Empty); // XXX pass args here
		}

		internal override Kind GetKind ()
		{
			return Kind.IMAGE;
		}
	}
}
