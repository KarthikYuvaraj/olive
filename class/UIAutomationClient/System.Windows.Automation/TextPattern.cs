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
//      Brad Taylor <brad@getcoded.net>
// 

using System;
using System.Windows.Automation.Text;

namespace System.Windows.Automation
{
	public class TextPattern : BasePattern
	{
#region Constructor
		private TextPattern ()
		{
		}
#endregion

#region Public Methods
		public TextPatternRange[] GetSelection ()
		{
			throw new NotImplementedException ();
		}

		public TextPatternRange[] GetVisibleRanges ()
		{
			throw new NotImplementedException ();
		}

		public TextPatternRange RangeFromChild (AutomationElement childElement)
		{
			throw new NotImplementedException ();
		}

		public TextPatternRange RangeFromPoint (Point screenLocation)
		{
			throw new NotImplementedException ();
		}
#endregion
		
#region Public Fields
		public static readonly AutomationTextAttribute AnimationStyleAttribute = TextPatternIdentifiers.AnimationStyleAttribute;

		public static readonly AutomationTextAttribute BackgroundColorAttribute = TextPatternIdentifiers.BackgroundColorAttribute;

		public static readonly AutomationTextAttribute BulletStyleAttribute = TextPatternIdentifiers.BulletStyleAttribute;

		public static readonly AutomationTextAttribute CapStyleAttribute = TextPatternIdentifiers.CapStyleAttribute;

		public static readonly AutomationTextAttribute CultureAttribute = TextPatternIdentifiers.CultureAttribute;

		public static readonly AutomationTextAttribute FontNameAttribute = TextPatternIdentifiers.FontNameAttribute;

		public static readonly AutomationTextAttribute FontSizeAttribute = TextPatternIdentifiers.FontSizeAttribute;

		public static readonly AutomationTextAttribute FontWeightAttribute = TextPatternIdentifiers.FontWeightAttribute;

		public static readonly AutomationTextAttribute ForegroundColorAttribute = TextPatternIdentifiers.ForegroundColorAttribute;

		public static readonly AutomationTextAttribute HorizontalTextAlignmentAttribute = TextPatternIdentifiers.HorizontalTextAlignmentAttribute;

		public static readonly AutomationTextAttribute IndentationFirstLineAttribute = TextPatternIdentifiers.IndentationFirstLineAttribute;

		public static readonly AutomationTextAttribute IndentationLeadingAttribute = TextPatternIdentifiers.IndentationLeadingAttribute;

		public static readonly AutomationTextAttribute IndentationTrailingAttribute = TextPatternIdentifiers.IndentationTrailingAttribute;

		public static readonly AutomationTextAttribute IsHiddenAttribute = TextPatternIdentifiers.IsHiddenAttribute;

		public static readonly AutomationTextAttribute IsItalicAttribute = TextPatternIdentifiers.IsItalicAttribute;

		public static readonly AutomationTextAttribute IsReadOnlyAttribute = TextPatternIdentifiers.IsReadOnlyAttribute;

		public static readonly AutomationTextAttribute IsSubscriptAttribute = TextPatternIdentifiers.IsSubscriptAttribute;

		public static readonly AutomationTextAttribute IsSuperscriptAttribute = TextPatternIdentifiers.IsSuperscriptAttribute;

		public static readonly AutomationTextAttribute MarginBottomAttribute = TextPatternIdentifiers.MarginBottomAttribute;

		public static readonly AutomationTextAttribute MarginLeadingAttribute = TextPatternIdentifiers.MarginLeadingAttribute;

		public static readonly AutomationTextAttribute MarginTopAttribute = TextPatternIdentifiers.MarginTopAttribute;

		public static readonly AutomationTextAttribute MarginTrailingAttribute = TextPatternIdentifiers.MarginTrailingAttribute;

		public static readonly Object MixedAttributeValue = TextPatternIdentifiers.MixedAttributeValue;

		public static readonly AutomationTextAttribute OutlineStylesAttribute = TextPatternIdentifiers.OutlineStylesAttribute;

		public static readonly AutomationTextAttribute OverlineColorAttribute = TextPatternIdentifiers.OverlineColorAttribute;

		public static readonly AutomationTextAttribute OverlineStyleAttribute = TextPatternIdentifiers.OverlineStyleAttribute;

		public static readonly AutomationPattern Pattern = TextPatternIdentifiers.Pattern;
		
		public static readonly AutomationTextAttribute StrikethroughColorAttribute = TextPatternIdentifiers.StrikethroughColorAttribute;

		public static readonly AutomationTextAttribute StrikethroughStyleAttribute = TextPatternIdentifiers.StrikethroughStyleAttribute;

		public static readonly AutomationTextAttribute TabsAttribute = TextPatternIdentifiers.TabsAttribute;

		public static readonly AutomationTextAttribute TextFlowDirectionsAttribute = TextPatternIdentifiers.TextFlowDirectionsAttribute;

		public static readonly AutomationTextAttribute UnderlineColorAttribute = TextPatternIdentifiers.UnderlineColorAttribute;

		public static readonly AutomationTextAttribute UnderlineStyleAttribute = TextPatternIdentifiers.UnderlineStyleAttribute;
#endregion
	}
}
