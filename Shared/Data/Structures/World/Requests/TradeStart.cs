﻿using Tera.Data.Enums;

namespace Tera.Data.Structures.World.Requests
{
    public class TradeStart : Request
    {
        public TradeStart(Player.Player target) : base(RequestType.TradeStart, true)
        {
            Target = target;
        }

        public override bool IsValid()
        {
            return Target != null;
        }
    }
}
