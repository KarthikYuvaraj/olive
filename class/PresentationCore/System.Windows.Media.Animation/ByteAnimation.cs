
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public class ByteAnimation : ByteAnimationBase
{
	public static readonly DependencyProperty ByProperty; /* XXX initialize */
	public static readonly DependencyProperty FromProperty; /* XXX initialize */
	public static readonly DependencyProperty ToProperty; /* XXX initialize */

	public ByteAnimation ()
	{
	}

	public ByteAnimation (byte toValue, Duration duration)
	{
	}

	public ByteAnimation (byte toValue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public ByteAnimation (byte fromValue, byte toValue, Duration duration)
	{
	}

	public ByteAnimation (byte fromValue, byte tovalue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public byte? By {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	public byte? From {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	public byte? To {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	public bool IsAdditive {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	public bool IsCumulative {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	public new ByteAnimation Clone ()
	{
		throw new NotImplementedException ();
	}

	protected override Freezable CreateInstanceCore ()
	{
		throw new NotImplementedException ();
	}

	protected override byte GetCurrentValueCore (byte defaultOriginValue, byte defaultDestinationValue, AnimationClock animationClock)
	{
		throw new NotImplementedException ();
	}
}


}