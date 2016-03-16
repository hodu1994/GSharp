﻿using GSharp.Graphic.Core;
using GSharp.Graphic.Statements;
using System;
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

namespace GSharp.Graphic.Holes
{
    /// <summary>
    /// NextConnectHole.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NextConnectHole : BaseStatementHole
    {
        public Brush Fill { get; set;}

        public override BaseBlock Block
        {
            get
            {
                return StatementBlock;
            }
        }

        public StatementBlock StatementBlock
        {
            get
            {
                return (StatementBlock)RealNextBlock.Child;
            }
            set
            {
                if (value == RealNextBlock.Child) return;

                if (StatementBlock != null)
                {
                    StatementBlock lastBlock = value.GetLastBlock();

                    if (!(lastBlock is PrevStatementBlock))
                    {
                        throw new Exception("끝 블럭이 중간에 들어갈 수 없습니다.");
                    }

                    PrevStatementBlock prevStatementBlock = (PrevStatementBlock)lastBlock;
                    prevStatementBlock.NextConnectHole.StatementBlock = StatementBlock;
                }

                UIElement element = VisualTreeHelper.GetParent(value) as UIElement;
                if (element is Panel)
                {
                    ((Panel)element).Children.Remove(value);
                }
                else if (element is Border)
                {
                    ((Border)element).Child = null;
                }

                RealNextBlock.Child = value;
            }
        }

        public NextConnectHole()
        {
            InitializeComponent();
        }
    }
}