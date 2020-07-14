# _Triangle_

#### _An App for Determining A Triangle, 7.14.20_

#### By _**Micheal Hansen & Sean Downs**_

## Description

_This application will take in the lengths of three sides, and then determine whether those vertices can make a triangle, and if so, what kind of triangle._

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
| Program inputs three sides into a Triangle object | "3, 4, 5" | Triangle(3, 4, 5) |
| Program determines if the three sides make a valid triangle | Triangle(2, 2, 8).IsValid() | "false" |
| If triangle is valid, program determines if the sides make an equilateral triangle | Triangle(3, 3, 3).IsEqualateral() | "true" |
| If triangle is valid, program determines if the sides make an isosceles triangle | Triangle(3, 3, 5).IsIsosceles() | "true" |
| If triangle if valid, program determines if the sides make a scalene triangle | Triangle(2, 3, 4).IsScalene() | "true" |
| Program outputs results to the console | "3, 4, 5" | "Triangle is scalene" |

## Setup/Installation Requirements

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Known Bugs

_None currently known._

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

* _VSCode_
* _C# and .NET_

### License

Copyright (c) 2020 **_Sean Downs &  Hansen_**

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*