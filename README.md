# TicTacToeGame

# Tic-Tac-Toe Game

This is a simple Tic-Tac-Toe game built using C# and Windows Forms. 
The game allows two players to take turns marking cells on a 3x3 grid, with the objective of forming a line (horizontally, vertically, or diagonally) with their symbol ('X' or 'O'). 
The game also supports detecting draws when the grid is fully filled without a winner.

## Features

- **Two-player mode**: Alternating turns between 'X' and 'O'.
- **Winner detection**: Automatically checks for a winner after each move.
- **Draw detection**: If all 9 moves are completed without a winner, the game ends in a draw.
- **Reset functionality**: After a game ends (win or draw), the board resets for a new game.
- **Interactive buttons**: Buttons change color when hovered over for better user experience.

## How to Play

1. Player 'X' always starts the game.
2. Players alternate by clicking on any empty button in the 3x3 grid.
3. The first player to get 3 marks in a row (horizontally, vertically, or diagonally) wins.
4. If all 9 cells are filled and there is no winner, the game ends in a draw.
5. After the game is over, you can start a new game by playing again.

## Code Overview

- **Game Initialization**: The form initializes with player 'X' starting and a turn counter set to 0.
- **Button Clicks**: Each button click places either 'X' or 'O' in the button, depending on the current player's turn.
- **Winner Check**: After each move, the game checks if there is a winner using multiple conditions that evaluate the grid.
- **Game Reset**: After a win or a draw, the game board resets, allowing players to start a new game.
- **UI Interactions**: Buttons change color on hover to enhance the gameplay experience.

## Technologies

- **C#**: Core programming language used for game logic and UI interaction.
- **Windows Forms**: Used to create the graphical interface.

## Getting Started

### Prerequisites

- **.NET Framework**: Make sure you have the .NET framework installed.

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/pixlypops/TicTacToeGame.git
    ```

2. Open the project in Visual Studio.
3. Build and run the project.

## Contributing

Feel free to fork this repository and submit pull requests if you'd like to improve the game or add new features.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
