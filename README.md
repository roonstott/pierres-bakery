# _Pierre's Bakery_

#### By _**Robert Onstott**_

#### _Enjoy the experience of shopping at an artisan bakery, choosing between loaves of bread and delightful pastries, with excellent bulk buying discounts, all from the comfort of your console_

## Technologies Used

* _C#_
* _.Net 7.0.0_
* _VS Code_
* _Github_

## Description

_This program is run entirely in the console using the dotnet developer platform. The premise is that it is used to input a customer order at a bakery, where loaves of bread are $5 per loaf (but the 3rd one is FREE) and pastries are $2 each (but the 3rd one is only $1 i.e. 3 for $5), which adds a little bit of complexity to computing the price. Thus the coding challenge. There are custom classes both for bread and for pastry. These classes are instantiated upon ordering, and the order quantities are stored as a property of these classes. Methods exist within the bakery item classes to calculate the total cost per item (based on the every 3rd discount pricing) and to produce the appropriate item string for the output (i.e. loaf or loaves)._

## Setup/Installation Requirements

* _Clone this repository to your own machine_
* _If you do not have dotnet installed on your machine, you must do so in order to run this program (https://dotnet.microsoft.com/en-us/download)_
* _Navigate to the PierresBakery directory_
  `$ cd PierresBakery/`
* _Run the program using the dotnet run command_
  `$ dotnet run`
* _Follow the prompts, entering yes or no when prompted, and entering integer quantities for the pasry items that you want to add to your order_
* _To test, navigate to the PierresSales.Tests directory_
  `$ cd ../PierresSales.Tests`
* _Enter the dotnet restore command_
   `$ dotnet restore`
* _Enter the dotnet test command_
    `$ dotnet test`
* _The test results will be printed to the console_

## Known Bugs

* _No known bugs at this time_

## License

_MIT_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

Copyright (c) _December 2022_ _Robert Onstott_
