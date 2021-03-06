﻿using System;
using System.Collections.Generic;

namespace GSharp.Extension
{
    [Serializable]
    public class GExtension
    {
        public string Path { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Summary { get; set; }

        public string Namespace { get; set; }

        public string Dependencies { get; set; }

        public List<GCommand> Commands { get; set; } = new List<GCommand>();

        public List<GControl> Controls { get; set; } = new List<GControl>();
    }
}
