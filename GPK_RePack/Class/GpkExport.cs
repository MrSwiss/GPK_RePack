﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPK_RePack.Class.Prop;

namespace GPK_RePack.Class
{
    class GpkExport
    {
        public int ClassIndex;
        public int SuperIndex;
        public int PackageIndex;

        public string Name;

        public long Unk1;
        public long Unk2;

        public int SerialSize;
        public int SerialOffset;

        public byte[] padding_unk = new byte[28];
        //28 byte byte padding? + 4 vor letztem

        public List<object> Properties;
        public byte[] data;

        public string ClassName;

        public GpkExport()
        {
            Properties = new List<object>();
        }

    }
}
