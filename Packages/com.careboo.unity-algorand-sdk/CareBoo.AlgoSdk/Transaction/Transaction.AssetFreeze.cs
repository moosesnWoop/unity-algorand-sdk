using System;
using AlgoSdk.Crypto;
using Unity.Collections;

namespace AlgoSdk
{
    public static partial class Transaction
    {
        public struct AssetFreeze
            : ITransaction
            , IEquatable<AssetFreeze>
        {
            Header header;

            Params @params;

            public Header Header
            {
                get => header;
                set => header = value;
            }

            public ulong Fee
            {
                get => header.Fee;
                set => header.Fee = value;
            }

            public ulong FirstValidRound
            {
                get => header.FirstValidRound;
                set => header.FirstValidRound = value;
            }
            public GenesisHash GenesisHash
            {
                get => header.GenesisHash;
                set => header.GenesisHash = value;
            }
            public ulong LastValidRound
            {
                get => header.LastValidRound;
                set => header.LastValidRound = value;
            }

            public Address Sender
            {
                get => header.Sender;
                set => header.Sender = value;
            }

            public FixedString32Bytes GenesisId
            {
                get => header.GenesisId;
                set => header.GenesisId = value;
            }

            public Address Group
            {
                get => header.Group;
                set => header.Group = value;
            }

            public Address Lease
            {
                get => header.Lease;
                set => header.Lease = value;
            }

            public byte[] Note
            {
                get => header.Note;
                set => header.Note = value;
            }

            public Address RekeyTo
            {
                get => header.RekeyTo;
                set => header.RekeyTo = value;
            }

            public Address FreezeAccount
            {
                get => @params.FreezeAccount;
                set => @params.FreezeAccount = value;
            }

            public ulong FreezeAsset
            {
                get => @params.FreezeAsset;
                set => @params.FreezeAsset = value;
            }

            public Optional<bool> AssetFrozen
            {
                get => @params.AssetFrozen;
                set => @params.AssetFrozen = value;
            }

            public AssetFreeze(
                ulong fee,
                ulong firstValidRound,
                Sha512_256_Hash genesisHash,
                ulong lastValidRound,
                Address sender,
                Address freezeAccount,
                ulong freezeAsset,
                bool assetFrozen
            )
            {
                header = new Header(
                    fee,
                    firstValidRound,
                    genesisHash,
                    lastValidRound,
                    sender,
                    TransactionType.AssetFreeze
                );
                @params = new Params(
                    freezeAccount,
                    freezeAsset,
                    assetFrozen
                );
            }

            public void CopyTo(ref RawTransaction rawTransaction)
            {
                rawTransaction.Header = header;
                rawTransaction.AssetFreezeParams = @params;
            }

            public void CopyFrom(RawTransaction rawTransaction)
            {
                header = rawTransaction.Header;
                @params = rawTransaction.AssetFreezeParams;
            }

            public bool Equals(AssetFreeze other)
            {
                return header.Equals(other.Header)
                    && @params.Equals(other.@params)
                    ;
            }

            public struct Params
                : IEquatable<Params>
            {
                public Address FreezeAccount;
                public ulong FreezeAsset;
                public Optional<bool> AssetFrozen;

                public Params(
                    Address freezeAccount,
                    ulong freezeAsset,
                    bool assetFrozen
                )
                {
                    FreezeAccount = freezeAccount;
                    FreezeAsset = freezeAsset;
                    AssetFrozen = assetFrozen;
                }

                public bool Equals(Params other)
                {
                    return FreezeAccount.Equals(other.FreezeAccount)
                        && FreezeAsset.Equals(other.FreezeAccount)
                        && AssetFrozen.Equals(other.AssetFrozen)
                        ;
                }
            }
        }
    }
}