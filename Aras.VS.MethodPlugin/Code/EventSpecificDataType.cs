﻿//------------------------------------------------------------------------------
// <copyright file="EventSpecificDataType.cs" company="Aras Corporation">
//     © 2017-2018 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Aras.VS.MethodPlugin.Code
{
	public class EventSpecificDataType
	{
		public EventSpecificData EventSpecificData { get; set; }

		public string InterfaceName { get; set; }

		public string EventDataClass { get; set; }

		public override string ToString()
		{
			return EventSpecificData.ToString();
		}
	}
}
