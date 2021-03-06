
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public abstract class PointKeyFrame : Freezable, IKeyFrame
{
	public static readonly DependencyProperty KeyTimeProperty
				= DependencyProperty.Register ("KeyTime", typeof (KeyTime), typeof (PointKeyFrame));

	public static readonly DependencyProperty ValueProperty
				= DependencyProperty.Register ("Value", typeof (Point), typeof (PointKeyFrame));

	protected PointKeyFrame ()
	{
	}

	protected PointKeyFrame (Point value)
	{
	}

	protected PointKeyFrame (Point value, KeyTime keyTime)
	{
	}

	public KeyTime KeyTime {
		get { return (KeyTime)GetValue (KeyTimeProperty); }
		set { SetValue (KeyTimeProperty, value); }
	}

	public Point Value {
		get { return (Point)GetValue (ValueProperty); }
		set { SetValue (ValueProperty, value); }
	}

	object IKeyFrame.Value {
		get { return Value; }
		set { Value = (Point)value; }
	}

	public Point InterpolateValue (Point baseValue, double keyFrameProgress)
	{
		throw new NotImplementedException ();
	}

	protected abstract Point InterpolateValueCore (Point baseValue, double keyFrameProgress);
}


}
