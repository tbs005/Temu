﻿using Tera.Data.Structures;

namespace Tera.Network.old_Client
{
    public class RpDialogShow : ARecvPacket
    {
        protected long TargetId;

        public override void Read()
        {
            TargetId = ReadLong();
        }

        public override void Process()
        {
            TeraObject obj = Uid.GetObject(TargetId) as TeraObject;

            if (obj != null)
                Communication.Logic.PlayerLogic.ShowDialog(Connection.Player, obj);
        }
    }
}