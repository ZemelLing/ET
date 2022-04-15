﻿using System.Collections.Generic;
using System.Linq;

namespace ET.Server
{
	[ChildType(typeof(Player))]
	public class PlayerComponent : Entity, IAwake, IDestroy
	{
		public readonly Dictionary<long, Player> idPlayers = new Dictionary<long, Player>();
	}
}