# Tic-Tac-Toe Game

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)

A classic Tic-Tac-Toe game implemented in C# using Windows Forms with a sleek, modern UI. Challenge a friend in this timeless two-player game of X's and O's!

## 📋 Features

- **Intuitive User Interface**: Clean and modern design with custom graphics
- **Two-Player Mode**: Play against a friend on the same computer
- **Turn Indicator**: Shows which player's turn it is
- **Winner Detection**: Automatically detects when a player wins or when there's a draw
- **Visual Feedback**: Winning combination is highlighted in green
- **Game Restart**: Reset the game board with a single click


## 🚀 Getting Started

### Prerequisites

- Windows operating system
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) 4.7.2 or later
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 or later (recommended)

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/aboubakr-jelloulat/Tic-Tac-Toe-Game.git
   ```

2. Open the solution file (`Tic-Tac-Toe.sln`) in Visual Studio

3. Build the solution (Press F6 or go to Build → Build Solution)

4. Run the application (Press F5 or go to Debug → Start Debugging)

### Image Setup

The game requires three image files for displaying X, O, and the empty cell:
- `x.jpg` - For Player 1's moves
- `o.jpg` - For Player 2's moves
- `qques.jpg` - For empty cells

Place these images in a directory and update the file paths in the code if necessary.

## 🎮 How to Play

1. The game starts with Player 1 (X)
2. Players take turns clicking on an empty cell to place their mark
3. The first player to get three of their marks in a row (horizontally, vertically, or diagonally) wins
4. If all cells are filled and no player has won, the game ends in a draw
5. Click "Restart Game" to play again

## 🛠️ Technical Details

- **Language**: C# 9.0
- **Framework**: .NET Framework 4.7.2
- **UI Framework**: Windows Forms
- **Design Pattern**: Event-driven programming

## 📝 Code Structure

- **Form1.cs**: Main game form containing UI elements and game logic
- **Enums**:
  - `enPlayer`: Tracks current player (Player1 or Player2)
  - `enWinner`: Defines possible game outcomes (Player1, Player2, Draw, GameInProgress)
- **Game Logic**:
  - Turn-based gameplay handling
  - Win condition checking across rows, columns, and diagonals
  - Game state management

## 🔄 Future Improvements

- Add an AI opponent with adjustable difficulty levels
- Implement game statistics tracking
- Add sound effects and animations
- Create a settings menu for customization options
- Add networked multiplayer support

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🤝 Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests.

## 👏 Acknowledgments

- Thanks to all those who've contributed to the project
- Inspired by the classic game of Tic-Tac-Toe
