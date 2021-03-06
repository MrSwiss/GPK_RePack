﻿using System;
using System.IO;
using GPK_RePack.Classes.Interfaces;

namespace GPK_RePack.Classes.Prop
{
    [Serializable]
    class GpkIntProperty : GpkBaseProperty, IProperty
    {
        public int value;

        public GpkIntProperty()
        {
            RecalculateSize();
        }
        public GpkIntProperty(GpkBaseProperty bp)
        {
            name = bp.name;
            type = bp.type;
            size = bp.size;
            arrayIndex = bp.arrayIndex;
        }

        public override string ToString()
        {
            return string.Format("ObjectName: {0} Type: {1} Value: {2}", name, type, value);
        }

        public void WriteData(BinaryWriter writer, GpkPackage package)
        {
            writer.Write(value);
        }

        public void ReadData(BinaryReader reader, GpkPackage package)
        {
            value = reader.ReadInt32();
        }

        public int RecalculateSize()
        {
            size = 4;
            return size;
        }

        public bool ValidateValue(string input)
        {
            int validate;
            if (int.TryParse(input, out validate))
            {
                return true;
            }

            return false;
        }

        public bool SetValue(string input)
        {
            if (!ValidateValue(input)) return false;
            value = Convert.ToInt32(input);
            return true;
        }
    }

}
