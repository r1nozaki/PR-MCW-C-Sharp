namespace Practical6
{
    internal class CounterApp
    {
        private readonly object _stateLock = new();
        private readonly object _consoleLock = new();
        private readonly ConsoleColor[] _textColors =
        [
            ConsoleColor.White,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Yellow,
            ConsoleColor.Magenta
        ];

        private int _counter;
        private int _colorIndex;
        private bool _isPaused;
        private bool _isRunning = true;

        public void Run()
        {
            Thread keyboardThread = new(HandleKeyboard)
            {
                IsBackground = true,
                Name = "Keyboard handler"
            };
            keyboardThread.Start();

            WriteSystemMessage("Controls: P - pause/resume, R - reset, C - change color, Q - quit");

            while (IsRunning())
            {
                Thread.Sleep(1000);

                int? valueToPrint = GetNextCounterValue();
                if (valueToPrint is null)
                {
                    continue;
                }

                WriteCounter(valueToPrint.Value);
            }

            WriteSystemMessage("Program finished.");
            Console.ResetColor();
        }

        private void HandleKeyboard()
        {
            while (IsRunning())
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.P:
                        TogglePause();
                        break;
                    case ConsoleKey.R:
                        ResetCounter();
                        break;
                    case ConsoleKey.C:
                        ChangeTextColor();
                        break;
                    case ConsoleKey.Q:
                        StopProgram();
                        break;
                }
            }
        }

        private int? GetNextCounterValue()
        {
            lock (_stateLock)
            {
                if (_isPaused)
                {
                    return null;
                }

                _counter++;
                return _counter;
            }
        }

        private void TogglePause()
        {
            bool isPaused;

            lock (_stateLock)
            {
                _isPaused = !_isPaused;
                isPaused = _isPaused;
            }

            WriteSystemMessage(isPaused ? "Paused." : "Resumed.");
        }

        private void ResetCounter()
        {
            lock (_stateLock)
            {
                _counter = 0;
            }

            WriteSystemMessage("Counter reset to 0.");
        }

        private void ChangeTextColor()
        {
            ConsoleColor currentColor;

            lock (_stateLock)
            {
                _colorIndex = (_colorIndex + 1) % _textColors.Length;
                currentColor = _textColors[_colorIndex];
            }

            WriteSystemMessage($"Text color changed to {currentColor}.");
        }

        private void StopProgram()
        {
            lock (_stateLock)
            {
                _isRunning = false;
            }
        }

        private bool IsRunning()
        {
            lock (_stateLock)
            {
                return _isRunning;
            }
        }

        private void WriteCounter(int counter)
        {
            ConsoleColor color;

            lock (_stateLock)
            {
                color = _textColors[_colorIndex];
            }

            lock (_consoleLock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"Counter: {counter}");
            }
        }

        private void WriteSystemMessage(string message)
        {
            lock (_consoleLock)
            {
                Console.ResetColor();
                Console.WriteLine(message);
            }
        }
    }
}
