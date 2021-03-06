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

using System;
using System.Security;

namespace System.Windows.Input {

	public class KeyEventArgs : KeyboardEventArgs {

		PresentationSource inputSource;
		Key key;

		[SecurityCritical]
		public KeyEventArgs (KeyboardDevice keyboard, PresentationSource inputSource,
				     int timestamp, Key key)
			: base (keyboard, timestamp)
		{
			this.inputSource = inputSource;
			this.key = key;
		}

		protected override void InvokeEventHandler (Delegate genericHandler, object genericTarget)
		{
			((KeyEventHandler)genericHandler)(genericTarget, this);
		}

		public Key ImeProcessedKey {
			get {
				throw new NotImplementedException ();
			}
		}

		public PresentationSource InputSource {
			[SecurityCritical]
			get { return inputSource; }
		}
		
		public bool IsDown {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsRepeat {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsToggled {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsUp {
			get {
				throw new NotImplementedException ();
			}
		}

		public Key Key {
			get { return key; }
		}

		public KeyStates KeyStates {
			get {
				throw new NotImplementedException ();
			}
		}

		public Key SystemKey {
			get {
				throw new NotImplementedException ();
			}
		}
	}
}
