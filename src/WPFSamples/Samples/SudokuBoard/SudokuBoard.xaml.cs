using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace WPFSamples.Samples.SudokuBoard
{
    [Category("ItemsControl")]
    [Description("A Sudoky board consisting of an ItemsControl using a UniformGrid and TextBoxes in its ItemTemplate")]
    [RelatedUrl("http://stackoverflow.com/questions/15344022/how-can-i-get-the-position-of-textbox-that-has-been-pressed", "How can I get the Position of textbox that has been pressed?")]
    public partial class SudokuBoard : SampleWindow
    {
        public SudokuBoard()
        {
            InitializeComponent();

            var random = new Random();

            var board = new List<SudokuViewModel>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board.Add(new SudokuViewModel() { Row = i, Column = j, Value = random.Next(1, 20) });
                }
            }

            DataContext = board;  
        }
    }
}
