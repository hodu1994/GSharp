﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GSharp.Graphic.Core;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;

namespace GSharp.Graphic.Objects
{
    /// <summary>
    /// NumberBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MultiplyBlock : NumberBlock
    {
        public override List<BaseHole> HoleList
        {
            get
            {
                return new List<BaseHole> { NumberHole1, NumberHole2 };
            }
        }

        public GCompute GCompute
        {
            get
            {
                GObject obj1 = NumberHole1.NumberBlock.GObject;
                GObject obj2 = NumberHole2.NumberBlock.GObject;
                return new GCompute(obj1, GCompute.OperatorType.MULTIPLY, obj2);
            }
        }

        public override GObject GObject
        {
            get
            {
                return GCompute;
            }
        }

        public override List<GBase> GObjectList
        {
            get
            {
                return new List<GBase> { GObject };
            }
        }

        public MultiplyBlock()
        {
            InitializeComponent();
            InitializeBlock();
        }
    }
}
