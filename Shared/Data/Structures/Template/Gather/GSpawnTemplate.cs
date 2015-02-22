﻿using Tera.Data.Structures.World;

namespace Tera.Data.Structures.Template.Gather
{
    [ProtoBuf.ProtoContract]
    public class GSpawnTemplate
    {
        [ProtoBuf.ProtoMember(1)]
        public int CollectionId;

        [ProtoBuf.ProtoMember(50)]
        public WorldPosition WorldPosition;
    }
}
