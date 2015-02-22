﻿using Tera.Communication.Logic;

namespace Tera.Network.old_Client
{
    class RpRessurect : ARecvPacket
    {
        protected int Type;
        protected int Unk;

        public override void Read()
        {
            Type = ReadD();
            Unk = ReadD();
        }

        public override void Process()
        {
            PlayerLogic.Ressurect(Connection.Player, Type, Unk);
        }
    }
}
