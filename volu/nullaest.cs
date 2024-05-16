// Check if the directory exists
if (!Directory.Exists(dirPath))
{
    try
    {
        // Attempt to create the directory
        Directory.CreateDirectory(dirPath);
        Console.WriteLine($"Directory created at: {dirPath}");
    }
    catch (IOException ioEx)
    {
        // Handle the case where the directory creation fails due to an IO exception
        Console.WriteLine($"IO Exception: {ioEx.Message}");
    }
    catch (UnauthorizedAccessException unAuthEx)
    {
        // Handle the case where the directory creation fails due to lack of permissions
        Console.WriteLine($"Unauthorized Access Exception: {unAuthEx.Message}");
    }
}
else
{
    // The directory already exists
    Console.WriteLine($"Directory already exists at: {dirPath}");
}
