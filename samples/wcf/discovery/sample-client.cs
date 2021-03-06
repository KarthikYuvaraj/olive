using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Discovery;

public class Test
{
	public static void Main ()
	{
		RunCodeUnderDiscoveryHost (new Uri ("http://localhost:37564"), new Uri ("http://localhost:4949"), UseCase1Core);
	}

	static void RunCodeUnderDiscoveryHost (Uri serviceUri, Uri dHostUri, Action<Uri,DiscoveryEndpoint> action)
	{
		var dbinding = new CustomBinding (new HttpTransportBindingElement ());
		var dAddress = new EndpointAddress (dHostUri);
		var dEndpoint = new DiscoveryEndpoint (dbinding, dAddress);
		var ib = new InspectionBehavior ();
		ib.RequestSending += delegate (ref Message msg, IClientChannel channel) {
			var mb = msg.CreateBufferedCopy (0x10000);
			msg = mb.CreateMessage ();
			Console.WriteLine (mb.CreateMessage ());
			return null;
			};
		ib.ReplyReceived += delegate (ref Message msg, object id) {
			var mb = msg.CreateBufferedCopy (0x10000);
			msg = mb.CreateMessage ();
			Console.WriteLine (mb.CreateMessage ());
			}; 
		dEndpoint.Behaviors.Add (ib);

		action (serviceUri, dEndpoint);
	}

	static void UseCase1Core (Uri serviceUri, DiscoveryEndpoint dEndpoint)
	{
		// actual client, with DiscoveryClientBindingElement
		var be = new DiscoveryClientBindingElement () { DiscoveryEndpointProvider = new ManagedDiscoveryEndpointProvider (dEndpoint) };
		var clientBinding = new CustomBinding (new BasicHttpBinding ());
		clientBinding.Elements.Insert (0, be);
		clientBinding.SendTimeout = TimeSpan.FromSeconds (10);
		clientBinding.ReceiveTimeout = TimeSpan.FromSeconds (10);
		var cf = new ChannelFactory<ITestService> (clientBinding, DiscoveryClientBindingElement.DiscoveryEndpointAddress);
		var ch = cf.CreateChannel ();
		Console.WriteLine (ch.Echo ("TEST"));
	}

		class ManagedDiscoveryEndpointProvider : DiscoveryEndpointProvider
		{
			public ManagedDiscoveryEndpointProvider (DiscoveryEndpoint endpoint)
			{
				this.endpoint = endpoint;
			}
			
			DiscoveryEndpoint endpoint;
			
			public override DiscoveryEndpoint GetDiscoveryEndpoint ()
			{
				return endpoint;
			}
		}

}

