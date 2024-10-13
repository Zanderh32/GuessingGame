# Guessing Game in C#

This project is a simple console-based **Guessing Game** where the player tries to guess a randomly selected number. The game provides feedback on whether the player's guess is too high or too low, and tracks the number of attempts made.

## Features

- **Random Number Generation**: A random number is generated between 0 and 1000 for the player to guess.
- **Player Input**: The player enters guesses and receives feedback based on their input.
- **Hints**: The game tells the player whether their guess is too high or too low after each attempt.
- **Guess Count**: The game keeps track of how many guesses the player has made.
- **Winning Condition**: The game ends when the player guesses the correct number, displaying a congratulatory message and the number of attempts taken.

## How It Works

1. **Random Number Generation**:
   - At the start of the game, a random number between 0 and 1000 is generated.
   
2. **Player Guesses**:
   - The player enters their guesses one at a time.
   - After each guess, the game will tell the player whether their guess was too high or too low.
   
3. **Game Over**:
   - When the player correctly guesses the number, the game displays the correct number and the total number of guesses.
   - The player is then given the option to play again or exit the game.
