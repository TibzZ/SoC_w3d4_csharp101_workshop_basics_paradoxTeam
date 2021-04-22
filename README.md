All done - Basic exercises to refresh my memory and also find at improved solutions compare to original code.
Exercises covers: For loop, if statement, string interpolation, random number generation, convertion of variable types

# C# 101

## Task 0

- Install the C# extension in Visual Studio Code. Search for C# for Visual Studio Code (powered by OmniSharp).
- Clone down the repo above if you haven't done so already!
- Navigate to the correct folder

## Task 1

### Step 1 - Hello, World?

- Open `Task1/Program.cs`
- Change the program so that it prints something other than `"Hello World!"`
- Run the application using the dotnet cli

### Step 2

- Use `Console.ReadLine` to take in the users name
- Store it in a variable with type string
- Print out `"Hello {name}!"`

## Task 2

### Step 1

- Open `Task2/Program.cs`
- Again, take in the users name and store in a variable (do not copy and paste, enjoy the repetition!)
- If the users name is of an even length
  - Print `"Hello {name}, you'll soon be a dotnet EVENgelist"`
- else
  - Print `"Hello {name}, you'll soon be a dODDnet Evangelist"`

### Step 2

- Add another condition to the above project
- If the name contains "dotnet" [this will help](https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-5.0#System_String_Contains_System_String_)
  - Print "Ahh, I can see you are already converted to the ways of dotnet!"
- else
  - same conditions as before

## Task 3

- Open `Task3/Program.cs`
- Create a variable called `counter` that has a value of `0` and a type of `int`
- Create a while loop that will run while `counter` is less than `15`
- On each iteration of the loop
  - print the value of `counter`
  - increment `counter` by 1

## Task 4

### Step 1

- Open `Task4/Program.cs`
- Create a for loop that prints the numbers 0 through to 100

### Step 2

- With in the loop add some conditional statements
- if the number is divisible by 3
  - print "Fizz"
- if the number is divisible by 5
  - print "Buzz"
- if the number is divisible by 3 and 5
  - print "FizzBuzz"
- else print the number

## Task 5 - Guess the number challenge

### Step 1

- Open `Task5/Program.cs`
- You will see we can given you a line of code
- Research how that line of code works [here](https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-5.0)

### Step 2

- Use the provided rand object to print a random integer between 0 and 5

### Step 3

- Take user input and compare it with a random number
- if it is the same number\*
  - print "You Win 🎉"
- else print "You Lose ☹️"

\* We will be comparing an integer and a string so you may need to do some research as to how to over come this problem. If you get stuck [look here for one possible solution](https://docs.microsoft.com/en-us/dotnet/api/system.int32.tostring?view=net-5.0#System_Int32_ToString)

