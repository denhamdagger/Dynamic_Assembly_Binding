using Class.Marshall;
using System;
using System.Reflection;

namespace Class.Library.v2
{
	public class Demo : MarshalByRefObject, IMarshall
	{
		public string FetchData()
		{
			return Assembly.GetExecutingAssembly().FullName;
		}
	}
}
