# MergeSort

A C# implementation of the Merge Sort algorithm, which sorts an array of randomly generated integers.

## Features

- Generates an array of random integers within the range of 10-99.
- Sorts the array using the Merge Sort algorithm.
- Provides visual output for each step of the sorting process.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Example](#example)
- [Output](#output)
- [Contributing](#contributing)

## Installation

To run this project, you need to have [.NET](https://dotnet.microsoft.com/download) installed on your machine.

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/MergeSort.git
    ```
2. Navigate to the project directory:
    ```bash
    cd MergeSort
    ```
3. Build the project:
    ```bash
    dotnet build
    ```

## Usage

1. Run the project:
    ```bash
    dotnet run
    ```
2. You can adjust the size of the array and other parameters by editing the code in `Program.cs` (if applicable):
    ```csharp
    int size = 20; // Example array size
    MergeSort sorter = new MergeSort(size);
    ```

## Example

Here is an example of how to use the `MergeSort` class in a C# project:

```csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int size = 10; // Specify the size of the array
        MergeSort sorter = new MergeSort(size);

        Console.WriteLine("Original array:");
        Console.WriteLine(sorter);

        sorter.Sort();

        Console.WriteLine("Sorted array:");
        Console.WriteLine(sorter);
    }
}
```
## Output
During the sorting process, the program prints each step of the algorithm. For example:

``` bash
Original array:
45 78 12 34 90 56 67 89 23 11 

split: 45 78 12 34 90 56 67 89 23 11 
       45 78 12 34 
       90 56 67 89 23 11 

split: 45 78 12 
       45 78 
       12 

merge: 45 
       78 

       12 

merge: 45 78 
       12 

split: 34 90 56 
       34 
       90 56 

merge: 34 
       90 

       56 

merge: 34 90 
       56 

merge: 12 34 56 90 
       78 

       89 23 11 

split: 78 
       89 
       23 11 

merge: 78 
       89 

       23 11 

merge: 78 89 
       23 11 

split: 23 
       11 

merge: 23 
       11 

merge: 23 11 

merge: 23 11 78 89 
       34 56 90 

merge: 12 23 11 34 56 78 89 90 

Sorted array:
11 12 23 34 45 56 67 78 89 90 
```
## Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your changes. For major changes, please open an issue first to discuss what you would like to change.
