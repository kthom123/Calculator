# Calculator

A calculator application created using C# (.NET8) and WinForms.

![Calculator](https://github.com/kthom123/Calculator/assets/99015262/4c789291-bbe9-4122-8266-c7bc83f3ea7d)

## Requirements

- Visual Studio (or any other C# IDE) installed on your system.

## How to Run

1. Clone the repository to your local machine using the following command:

   ```
   git clone https://github.com/your-username/calculator.git
   ```

2. Open the solution file (`Calculator.sln`) in Visual Studio.

3. Build the solution by clicking on the "Build" menu and selecting "Build Solution".

4. Once the build is successful, run the application by pressing `F5` or clicking on the "Start" button in Visual Studio.

5. The calculator application should now open on your screen. You can perform various arithmetic operations using the buttons provided.

## Features

- Addition, subtraction, multiplication, and division of numbers.
- Square root, square, reciprocal, and percentage operations.
- Clear (`C`) and all clear (`AC`) functionalities.
- Supports input of numbers up to 20 characters.
- Results are displayed with up to 15 decimal places.

## Libraries
1. **System**
   - This is the root namespace for fundamental classes and base classes that define commonly-used values and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

2. **System.Drawing**
   - This namespace provides access to basic graphics functionality. It includes classes for working with fonts, colors, bitmaps, and drawing shapes. In this code, it's specifically used for setting the font of the `TxtDisplay1` control.

3. **System.Windows.Forms**
   - This namespace provides classes for creating Windows-based applications that take full advantage of the rich user interface features available in the Microsoft Windows operating system. It includes controls such as forms, buttons, text boxes, and event handlers. This code makes extensive use of the `System.Windows.Forms` namespace to create and manage the calculator's user interface.

## Usage

- Click on the number buttons to input numbers.
- Click on the math operation buttons to perform arithmetic operations.
- Use the `C` button to delete the last entered digit.
- Use the `AC` button to clear the entire input.
- The result is displayed in the top text box.
- (Please note that all M buttons are for display purposes only and have no functions)

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or create a pull request.

