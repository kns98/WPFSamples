using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Linq;

namespace WPFSamples.Samples.ChessBoard
{
    [Category("Highlights")]
    [Description("An MVVM based Chess board showing how to dynamically position items in a WPF Grid by row and column using DataBinding.")]
    [RelatedUrl("http://stackoverflow.com/questions/15513357/how-to-draw-an-image-in-c-sharp", "How to Draw an Image in C#")]
    public partial class ChessBoard : SampleWindow
    {
        private const int RowCount = 8;
        private const int ColCount = 8;

        public ObservableCollection<ChessPiece> Pieces { get; set; }

        public ChessBoard()
        {
            Pieces = new ObservableCollection<ChessPiece>();
            InitializeComponent();
            DataContext = this;
            CreateBoard();
            NewGame();
        }

        private void CreateBoard()
        {
            for (var row = 0; row < RowCount; row++)
            {
                var isBlack = row % 2 == 1;
                for (int col = 0; col < ColCount; col++)
                {
                    var square = new Rectangle { Fill = isBlack ? Brushes.Black : Brushes.White };
                    SquaresGrid.Children.Add(square);
                    isBlack = !isBlack;
                }
            }
        }

        private void NewGame()
        {
            Pieces.Add(new ChessPiece() { Row = 0, Column = 0, Type = ChessPieceTypes.Tower, IsBlack = true});
            Pieces.Add(new ChessPiece() { Row = 0, Column = 1, Type = ChessPieceTypes.Knight, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 2, Type = ChessPieceTypes.Bishop, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 3, Type = ChessPieceTypes.Queen, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 4, Type = ChessPieceTypes.King, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 5, Type = ChessPieceTypes.Bishop, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 6, Type = ChessPieceTypes.Knight, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 7, Type = ChessPieceTypes.Tower, IsBlack = true });

            Enumerable
                .Range(0, 8)
                .Select(x => new ChessPiece()
                {
                    Row = 1,
                    Column = x,
                    IsBlack = true,
                    Type = ChessPieceTypes.Pawn
                })
                .ToList()
                .ForEach(Pieces.Add);

            Pieces.Add(new ChessPiece() { Row = 7, Column = 0, Type = ChessPieceTypes.Tower, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 1, Type = ChessPieceTypes.Knight, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 2, Type = ChessPieceTypes.Bishop, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 3, Type = ChessPieceTypes.Queen, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 4, Type = ChessPieceTypes.King, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 5, Type = ChessPieceTypes.Bishop, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 6, Type = ChessPieceTypes.Knight, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 7, Type = ChessPieceTypes.Tower, IsBlack = false });

            Enumerable.Range(0, 8).Select(x => new ChessPiece()
            {
                Row = 6,
                Column = x,
                IsBlack = false,
                Type = ChessPieceTypes.Pawn
            }).ToList().ForEach(Pieces.Add);

        }
    }
}
