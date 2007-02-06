//
// InternalEncryptedKeyIdentifierClause.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2007 Novell, Inc.  http://www.novell.com
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
using System.Collections.ObjectModel;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.IdentityModel.Tokens;

namespace System.ServiceModel.Security.Tokens
{
	internal class InternalEncryptedKeyIdentifierClause : BinaryKeyIdentifierClause
	{
		public InternalEncryptedKeyIdentifierClause (byte [] hash)
			: base (null, hash, false)
		{
		}

		public override bool Matches (SecurityKeyIdentifierClause keyIdentifierClause)
		{
			InternalEncryptedKeyIdentifierClause kic = keyIdentifierClause as InternalEncryptedKeyIdentifierClause;
			if (kic == null)
				return false;
			return Matches (kic.GetRawBuffer ());
		}

		public bool Matches (byte [] otherHash)
		{
			byte [] hash = GetRawBuffer ();
			if (otherHash == null)
				throw new ArgumentNullException ("otherHash");
			if (hash.Length != otherHash.Length)
				return false;
			for (int i = 0; i < hash.Length; i++)
				if (hash [i] != otherHash [i])
					return false;
			return true;
		}
	}
}
