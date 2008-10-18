// GetMemberBinderHelper.cs
//
// Authors:
//   Olivier Dufour <olivier.duff@gmail.com>
//
// Copyright (C) 2008 Olivier Dufour
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
//

using System;
using Microsoft.Scripting;
using Microsoft.Scripting.Actions;

namespace Microsoft.JScript.Runtime.Actions {

	public class GetMemberBinderHelper<T> : Microsoft.Scripting.Actions.GetMemberBinderHelper<T> {
		public GetMemberBinderHelper (CodeContext context, OldGetMemberAction action, object[] args) : base (context, action, args)
		{
			throw new NotImplementedException ();
		}

		public StandardRule<T> MakeRule ()
		{
			throw new NotImplementedException ();
		}
	}
}
