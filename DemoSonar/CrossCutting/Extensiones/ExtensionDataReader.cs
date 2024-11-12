﻿using System;
using System.Data;

namespace CrossCutting
{
    public static class ExtensionDataReader
    {
        public static Int16 GetValueInt16(this IDataReader reader, int ordinal)
        {
            Int16 value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetInt16(ordinal);
            }

            return value;
        }

        public static int GetValueInt32(this IDataReader reader, int ordinal)
        {
            int value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetInt32(ordinal);
            }

            return value;
        }

        public static decimal GetValueDecimal(this IDataReader reader, int ordinal)
        {
            decimal value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetDecimal(ordinal);
            }

            return value;
        }

        public static string GetValueString(this IDataReader reader, int ordinal)
        {
            string value = string.Empty;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetString(ordinal);
            }

            return value;
        }

        public static DateTime GetValueDateTime(this IDataReader reader, int ordinal)
        {
            DateTime value = DateTime.MinValue;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetDateTime(ordinal);
            }

            return value;
        }

        public static Boolean GetValueBoolean(this IDataReader reader, int ordinal)
        {
            bool value = false;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetBoolean(ordinal);
            }

            return value;
        }

        public static Guid GetValueGuid(this IDataReader reader, int ordinal)
        {
            Guid value = Guid.NewGuid();

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetGuid(ordinal);
            }

            return value;
        }

        public static byte GetValueByte(this IDataReader reader, int ordinal)
        {
            byte value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetByte(ordinal);
            }

            return value;
        }

        public static byte[] GetValueBytes(this IDataReader reader, int ordinal, int len)
        {
            byte[] buffer = new byte[len];

            if (!reader.IsDBNull(ordinal))
            {

                reader.GetBytes(ordinal, 0, buffer, 0, len);
            }

            return buffer;
        }

        public static byte GetValueByte2(this IDataReader reader, int ordinal)
        {
            byte value = 0;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetByte(ordinal);
            }

            return value;
        }

        public static byte[] GetValueBytes2(this IDataReader reader, int ordinal, int len)
        {
            byte[] buffer = new byte[len];

            if (!reader.IsDBNull(ordinal))
            {

                reader.GetBytes(ordinal, 0, buffer, 0, len);
            }

            return buffer;
        }

        public static Boolean GetValueBoolean2(this IDataReader reader, int ordinal)
        {
            bool value = false;

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetBoolean(ordinal);
            }

            return value;
        }

        public static Guid GetValueGuid2(this IDataReader reader, int ordinal)
        {
            Guid value = Guid.NewGuid();

            if (!reader.IsDBNull(ordinal))
            {
                value = reader.GetGuid(ordinal);
            }

            return value;
        }
    }
}
