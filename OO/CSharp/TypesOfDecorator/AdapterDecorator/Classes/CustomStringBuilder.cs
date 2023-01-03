using System.Runtime.Serialization;
using System.Text;

namespace AdapterDecorator.Classes
{
    public class CustomStringBuilder
    {
        private StringBuilder sb = new();

        public static implicit operator CustomStringBuilder(string s)
        {
            var cs = new CustomStringBuilder(); 
            cs.sb.Append(s);
            return cs;
        }

        public static CustomStringBuilder operator +(CustomStringBuilder csb, string s)
        {
            csb.sb.Append(s);
            return csb;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)sb).GetObjectData(info, context);
        }

        public CustomStringBuilder Append(bool value)
        {
            sb.Append(value);
            return this;    
        }

        public CustomStringBuilder Append(byte value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(char value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(char value, int repeatCount)
        {
            sb.Append(value, repeatCount);
            return this;
        }

        public CustomStringBuilder Append(char[]? value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(char[]? value, int startIndex, int charCount)
        {
            sb.Append(value, startIndex, charCount);
            return this;
        }

        public CustomStringBuilder Append(decimal value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(double value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(short value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(int value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(long value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(object? value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ReadOnlyMemory<char> value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ReadOnlySpan<char> value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(sbyte value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(float value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(string? value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(string? value, int startIndex, int count)
        {
            sb.Append(value, startIndex, count);
            return this;
        }

        public CustomStringBuilder Append(CustomStringBuilder? value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(StringBuilder? value, int startIndex, int count)
        {
            sb.Append(value, startIndex, count);
            return this;
        }

        public CustomStringBuilder Append(ushort value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(uint value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ulong value)
        {
            sb.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ref StringBuilder.AppendInterpolatedStringHandler handler)
        {
            sb.Append(ref handler);
            return this;
        }

        public CustomStringBuilder Append(IFormatProvider? provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
        {
            sb.Append(provider, ref handler);
            return this;
        }

        public CustomStringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0)
        {
            sb.AppendFormat(provider, format, arg0);
            return this;
        }

        public CustomStringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
        {
            sb.AppendFormat(provider, format, arg0, arg1);
            return this;
        }

        public CustomStringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
        {
            sb.AppendFormat(provider, format, arg0, arg1, arg2);
            return this;
        }

        public CustomStringBuilder AppendFormat(IFormatProvider? provider, string format, params object?[] args)
        {
            sb.AppendFormat(provider, format, args);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object? arg0)
        {
            sb.AppendFormat(format, arg0);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object? arg0, object? arg1)
        {
            sb.AppendFormat(format, arg0, arg1);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object? arg0, object? arg1, object? arg2)
        {
            sb.AppendFormat(format, arg0, arg1, arg2);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, params object?[] args)
        {
            sb.AppendFormat(format, args);
            return this;
        }

        public CustomStringBuilder AppendJoin(char separator, params object?[] values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendJoin(char separator, params string?[] values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendJoin(string? separator, params object?[] values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendJoin(string? separator, params string?[] values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
        {
            sb.AppendJoin(separator, values);
            return this;
        }

        public CustomStringBuilder AppendLine()
        {
            sb.AppendLine();
            return this;
        }

        public CustomStringBuilder AppendLine(string? value)
        {
            sb.AppendLine(value);
            return this;
        }

        public CustomStringBuilder AppendLine(ref StringBuilder.AppendInterpolatedStringHandler handler)
        {
            sb.AppendLine(ref handler);
            return this;
        }

        public CustomStringBuilder AppendLine(IFormatProvider? provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
        {
            sb.AppendLine(provider, ref handler);
            return this;
        }

        public CustomStringBuilder Clear()
        {
            sb.Clear();
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            sb.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public void CopyTo(int sourceIndex, Span<char> destination, int count)
        {
            sb.CopyTo(sourceIndex, destination, count);
        }

        public int EnsureCapacity(int capacity)
        {
            return sb.EnsureCapacity(capacity);
        }

        public bool Equals(ReadOnlySpan<char> span)
        {
            return sb.Equals(span);
        }

        public bool Equals(CustomStringBuilder? sb)
        {
            return this.sb.Equals(sb);
        }

        public StringBuilder.ChunkEnumerator GetChunks()
        {
            sb.GetChunks();
            return sb.GetChunks();
        }

        public CustomStringBuilder Insert(int index, bool value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, byte value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char[]? value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char[]? value, int startIndex, int charCount)
        {
            sb.Insert(index, value, startIndex, charCount);
            return this;
        }

        public CustomStringBuilder Insert(int index, decimal value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, double value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, short value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, int value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, long value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, object? value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, ReadOnlySpan<char> value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, sbyte value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, float value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, string? value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, string? value, int count)
        {
            sb.Insert(index, value, count);
            return this;
        }

        public CustomStringBuilder Insert(int index, ushort value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, uint value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, ulong value)
        {
            sb.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Remove(int startIndex, int length)
        {
            sb.Remove(startIndex, length);
            return this;
        }

        public CustomStringBuilder Replace(char oldChar, char newChar)
        {
            sb.Replace(oldChar, newChar);
            return this;
        }

        public CustomStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            sb.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public CustomStringBuilder Replace(string oldValue, string? newValue)
        {
            sb.Replace(oldValue, newValue);
            return this;
        }

        public CustomStringBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
        {
            sb.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        public int Capacity
        {
            get => sb.Capacity;
            set => sb.Capacity = value;
        }

        public char this[int index]
        {
            get => sb[index];
            set => sb[index] = value;
        }

        public int Length
        {
            get => sb.Length;
            set => sb.Length = value;
        }

        public int MaxCapacity => sb.MaxCapacity;
    }
}
