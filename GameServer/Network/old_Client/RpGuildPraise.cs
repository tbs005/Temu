﻿using Tera.Network.old_Server;
using Utils;

namespace Tera.Network.old_Client
{
    public class RpGuildPraise : ARecvPacket
    {
        protected string GuildName;

        public override void Read()
        {
            ReadByte(); // 7
            ReadByte(); // 0
            ReadByte(); // 1
            GuildName = ReadString();
        }

        public override void Process()
        {
            if(GuildName == "")
                return;

            if(Connection.Player.LastPraise != -1 && RandomUtilities.GetRoundedUtc() - Connection.Player.LastPraise > 86400)
            {
                Connection.Player.LastPraise = -1;
                Connection.Player.PraiseGiven = 0;
            }


            if(Connection.Player.PraiseGiven >= 3)
            {
                new SpSystemNotice("Sorry, but you've exceeded the limit of 3 praises per day.").Send(Connection);
                return;
            }

            Connection.Player.PraiseGiven++;
            Connection.Player.LastPraise = RandomUtilities.GetRoundedUtc();

            Communication.Global.GuildService.PraiseGuild(GuildName);
            Communication.Global.GuildService.SendServerGuilds(Connection.Player, 1);
            SystemMessages.YouPraiseGuildNowYouHavePraisesLeft(GuildName, 3 - Connection.Player.PraiseGiven).Send(Connection.Player);
        }
    }
}
