﻿using Tera.Network.old_Server;

namespace Tera.Network.old_Client
{
    public class RpZoneUnk : ARecvPacket
    {
        public override void Read()
        {
            //empty packet
        }

        public override void Process()
        {
            new SpZoneUnkAnswer(1).Send(Connection);
        }
    }
}