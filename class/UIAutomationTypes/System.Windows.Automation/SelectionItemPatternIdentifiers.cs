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
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
//      Sandy Armstrong <sanfordarmstrong@gmail.com>
// 

using System;

namespace System.Windows.Automation
{
	public static class SelectionItemPatternIdentifiers
	{
#region Constructor
		internal const int PatternId = 10010;
		internal const int ElementAddedToSelectionEventId = 20010;
		internal const int ElementRemovedFromSelectionEventId = 20011;
		internal const int ElementSelectedEventId = 20012;
		internal const int IsSelectedPropertyId = 30079;
		internal const int SelectionContainerPropertyId = 30080;
		
		static SelectionItemPatternIdentifiers ()
		{
			Pattern =
				new AutomationPattern (PatternId,
				                       "SelectionItemPatternIdentifiers.Pattern");
			ElementAddedToSelectionEvent =
				new AutomationEvent (ElementAddedToSelectionEventId,
				                     "SelectionItemPatternIdentifiers.ElementAddedToSelectionEvent");
			ElementRemovedFromSelectionEvent =
				new AutomationEvent (ElementRemovedFromSelectionEventId,
				                     "SelectionItemPatternIdentifiers.ElementRemovedFromSelectionEvent");
			ElementSelectedEvent =
				new AutomationEvent (ElementSelectedEventId,
				                     "SelectionItemPatternIdentifiers.ElementSelectedEvent");
			IsSelectedProperty =
				new AutomationProperty (IsSelectedPropertyId,
				                     "SelectionItemPatternIdentifiers.IsSelectedProperty");
			SelectionContainerProperty =
				new AutomationProperty (SelectionContainerPropertyId,
				                     "SelectionItemPatternIdentifiers.SelectionContainerProperty");
		}
		
#endregion
		
#region Public Fields
		
		public static readonly AutomationPattern Pattern;
		public static readonly AutomationEvent ElementAddedToSelectionEvent;
		public static readonly AutomationEvent ElementRemovedFromSelectionEvent;
		public static readonly AutomationEvent ElementSelectedEvent;
		public static readonly AutomationProperty IsSelectedProperty;
		public static readonly AutomationProperty SelectionContainerProperty;
		
#endregion
	}
}
