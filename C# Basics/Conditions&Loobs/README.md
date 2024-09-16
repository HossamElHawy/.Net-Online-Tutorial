# .NEt Online Tutorial

# C# Conditions and Loops

## Conditions in C#

Conditions are used to execute code based on whether a certain condition is true or false. The most common conditional statements are:

- **`if`**: Executes a block of code if the condition is true.
    ```csharp
    if (condition)
    {
        // Code to execute if the condition is true
    }
    ```

- **`else`**: Executes a block of code if the condition in the `if` statement is false.
    ```csharp
    if (condition)
    {
        // Code to execute if the condition is true
    }
    else
    {
        // Code to execute if the condition is false
    }
    ```

- **`else if`**: Tests multiple conditions in sequence.
    ```csharp
    if (condition1)
    {
        // Code to execute if condition1 is true
    }
    else if (condition2)
    {
        // Code to execute if condition2 is true
    }
    else
    {
        // Code to execute if all conditions are false
    }
    ```

- **`switch`**: A more readable way to handle multiple conditions based on a single value.
    ```csharp
    switch (variable)
    {
        case value1:
            // Code to execute if variable equals value1
            break;
        case value2:
            // Code to execute if variable equals value2
            break;
        default:
            // Code to execute if no case matches
            break;
    }
    ```

## Loops in C#

Loops are used to repeat a block of code as long as a specified condition is true. Here are the most commonly used loops:

- **`for`**: Executes a block of code a specific number of times.
    ```csharp
    for (int i = 0; i < 10; i++)
    {
        // Code to execute for each iteration
    }
    ```

- **`while`**: Repeats a block of code while the condition is true.
    ```csharp
    while (condition)
    {
        // Code to execute while the condition is true
    }
    ```

- **`do...while`**: Similar to `while`, but the condition is evaluated after the loop body has been executed at least once.
    ```csharp
    do
    {
        // Code to execute at least once
    }
    while (condition);
    ```

- **`foreach`**: Iterates over each element in a collection or array.
    ```csharp
    foreach (var item in collection)
    {
        // Code to execute for each item in the collection
    }
    ```

---



