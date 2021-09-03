using System;
using AlgoSdk.MsgPack;
using Unity.Collections;
using Unity.Jobs;

namespace AlgoSdk
{
    public struct CatchupMessage
        : IMessagePackObject
        , IEquatable<CatchupMessage>
    {
        public FixedString512Bytes Message;

        public bool Equals(CatchupMessage other)
        {
            return this.Equals(ref other);
        }
    }
}

namespace AlgoSdk.MsgPack
{
    internal static partial class FieldMaps
    {
        internal static readonly Field<CatchupMessage>.Map catchupMessageFields =
            new Field<CatchupMessage>.Map()
                .Assign("catchup-message", (ref CatchupMessage x) => ref x.Message)
                ;
    }
}