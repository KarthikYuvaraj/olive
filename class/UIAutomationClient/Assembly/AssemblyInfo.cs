﻿// Permission is hereby granted, free of charge, to any person obtaining 
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
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
//      Brad Taylor <brad@getcoded.net>
// 

using System;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

// General Information about the UIAutomationClient assembly
// v3.0 Assembly

[assembly: AssemblyCompany (Consts.MonoCompany)]
[assembly: AssemblyProduct (Consts.MonoProduct)]
[assembly: AssemblyCopyright (Consts.MonoCopyright)]
[assembly: AssemblyVersion (Consts.FxVersion)]
[assembly: AssemblyFileVersion (Consts.WinFileVersion)]

[assembly: NeutralResourcesLanguage ("en")]
[assembly: CLSCompliant (true)]
[assembly: AssemblyDelaySign (true)]
[assembly: AssemblyKeyFile ("../winfx3.pub")]

[assembly: ComVisible (false)]
[assembly: AllowPartiallyTrustedCallers]

[assembly: CompilationRelaxations (CompilationRelaxations.NoStringInterning)]
[assembly: Debuggable (DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility (WrapNonExceptionThrows = true)]
[assembly: PermissionSet (SecurityAction.RequestMinimum, Name = "FullTrust")]
[assembly: SecurityPermission (SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: InternalsVisibleTo("UIAutomationWinforms, PublicKey=00240000048000009400000006020000002400005253413100040000110000004bb98b1af6c1df0df8c02c380e116b7a7f0c8c827aecfccddc6e29b7c754cd608b49dfcef4df9699ad182e50f66afa4e68dabc7b6aeeec0aa4719a5f8e0aae8c193080a706adc3443a8356b1f254142034995532ac176398e12a30f6a74a119a89ac47672c9ae24d7e90de686557166e3b873cd707884431a0451d9d6f7fe795")]
