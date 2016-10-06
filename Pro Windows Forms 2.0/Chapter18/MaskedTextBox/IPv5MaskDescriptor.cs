using System;
using System.Windows.Forms.Design;

namespace Microsoft.Samples
{
	public class IPv5MaskDescriptor : MaskDescriptor
	{
        public override string Mask
		{
			get { return "099.099.099.099"; }
		}

		public override string Name
		{
			get { return "IPv5 IP address"; }
		}

		public override string Sample
		{
			get { return "128.128.128.128"; }
		}

		public override Type ValidatingType
		{
			get { return typeof(IPv5); }
		}

	}
}
