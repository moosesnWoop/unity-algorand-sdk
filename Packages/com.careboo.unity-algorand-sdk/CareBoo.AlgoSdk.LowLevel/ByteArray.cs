
using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace AlgoSdk.LowLevel
{
    public interface IByteArray
    {
        IntPtr Buffer { get; }
        int Length { get; }
    }

    public static class ByteArray
    {
        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        public static void CheckElementAccess(int index, int length)
        {
            if (index < 0 || index >= length)
                throw new IndexOutOfRangeException($"Index {index} is out of range [0, {length}).");
        }

        public static byte GetByteAt<TByteArray>(ref this TByteArray bytes, int index)
            where TByteArray : unmanaged, IByteArray
        {
            CheckElementAccess(index, bytes.Length);
            unsafe
            {
                return UnsafeUtility.ReadArrayElement<byte>((byte*)bytes.Buffer, index);
            }
        }

        public static void SetByteAt<TByteArray>(ref this TByteArray bytes, int index, byte value)
            where TByteArray : unmanaged, IByteArray
        {
            CheckElementAccess(index, bytes.Length);
            unsafe
            {
                UnsafeUtility.WriteArrayElement<byte>((byte*)bytes.Buffer, index, value);
            }
        }

        public static void Copy<T, U>(ref T from, ref U to)
            where T : unmanaged, IByteArray
            where U : unmanaged, IByteArray
        {
            var length = math.min(from.Length, to.Length);
            for (var i = 0; i < length; i++)
                to.SetByteAt(i, from.GetByteAt(i));
        }
    }
}