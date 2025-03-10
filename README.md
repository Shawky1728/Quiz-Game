# Quiz Game

## Description
The **Quiz Game** is a simple console-based trivia game developed in C#. Players answer a series of predefined questions, and their score is calculated based on correct answers.

## Features
- Three trivia questions
- Real-time feedback on answers
- Score tracking system
- Simple and interactive console interface

## Installation and Usage
### Prerequisites
- .NET SDK installed on your machine

### Steps to Run
1. Clone the repository or copy the code into a C# project.
2. Open the project in a C# development environment (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.

### Running the Application
When the program starts, you'll see:
```
Welcome To My Game (^_^) Press Any Key to start
```
1. Press any key to start the quiz.
2. Answer each question by typing your response and pressing `Enter`.
3. After answering all questions, your final score will be displayed.

## How It Works
- The game stores a set of questions and answers.
- It iterates through each question, prompting the user for an answer.
- The `CheckAnswer()` method compares user input with the correct answer.
- At the end, the total score is displayed.

## Limitations
- Fixed number of questions (currently 3).
- No case insensitivity (answers must match exactly).
- No persistent storage (scores are lost after the game ends).

## Future Improvements
- Add more questions and randomization.
- Improve answer validation (case-insensitive, partial matches, etc.).
- Implement a scoring leaderboard using file or database storage.

## License
This project is open-source and available under the MIT License.

---
Enjoy playing the **Quiz Game**! 🎮

