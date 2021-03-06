﻿namespace Tera.Network.old_Client
{
    class RpGuildRankAdd : ARecvPacket
    {
        protected string RankName;

        public override void Read()
        {
            ReadWord();
            RankName = ReadString();
        }

        public override void Process()
        {
            Communication.Global.GuildService.CreateNewRank(Connection.Player.Guild, RankName);
        }
    }
}
