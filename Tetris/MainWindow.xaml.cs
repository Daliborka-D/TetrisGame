﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/TileEmpty.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileBlue.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileOrange.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileEmpty.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileYellow.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileGreen.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TilePurple.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileRed.png", UriKind.Relative)),

        };

        private readonly ImageSource[] blockImages = new ImageSource[]
            {
                new BitmapImage (new Uri ("Assets/Block-Empty.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-I.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-J.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-L.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-O.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-S.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-T.png", UriKind.Relative)),
                new BitmapImage (new Uri ("Assets/Block-Z.png", UriKind.Relative)),
                
            };

        private readonly Image[,] imageControls;

        private GameState gameState = new GameState();

               
        public MainWindow()
        {
            InitializeComponent();
        }

        private Image[,] SetupGameCanvas (GameGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 25;

            for (int r = 0; r < grid.Rows; r++)
            {
                for(int c = 0; c < grid.Columns; c++)
                {
                    Image imageControl = new Image
                    {
                        Width = cellSize,
                        Height = cellSize
                    };

                    Canvas.SetTop(imageControl, (r - 2) * cellSize);
                    Canvas.SetLeft(imageControl, c * cellSize);
                    GameCanvas.Children.Add(imageControl);
                    imageControls[r, c] = imageControl;
                }
                return imageControls;
            }
        }


    }
}