using System;

namespace AlgoSdk
{
    [AlgoApiObject]
    public struct HealthCheck
        : IEquatable<HealthCheck>
    {
        [AlgoApiField("data", "data")]
        public AlgoApiObject Data;

        [AlgoApiField("db-available", "db-available")]
        public bool DatabaseAvailable;

        [AlgoApiField("errors", "errors")]
        public string[] Errors;

        [AlgoApiField("is-migrating", "is-migrating")]
        public bool IsMigrating;

        [AlgoApiField("message", "message")]
        public string Message;

        [AlgoApiField("round", "round")]
        public ulong Round;

        public bool Equals(HealthCheck other)
        {
            return Data.Equals(other.Data)
                && DatabaseAvailable.Equals(other.DatabaseAvailable)
                && ArrayComparer.Equals(Errors, other.Errors)
                && IsMigrating.Equals(other.IsMigrating)
                && Message.Equals(other.Message)
                && Round.Equals(other.Round)
                ;
        }
    }
}
