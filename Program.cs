using System.Diagnostics;
class MainProgram {
    public static void Main(string[] args) {
        Console.Write("O or C: ");
        string? input = Console.ReadLine();
        if (input != null) {
            if (input.ToLower() == "o") {
                Console.Write("Enter the path of the executable (if nothing provided then opening notepad++): ");
                string? programStart = Console.ReadLine();
                if (programStart != null) {
                    Process.Start($"{programStart}");
                } else {
                    Process.Start("C:\\Program Files\\Notepad++\\notepad++.exe");
                }
            } else if (input.ToLower() == "c") {
                Console.Write("Enter the program name to close: ");
                string? programName = Console.ReadLine();
                if (programName != null) {
                    Process[] processes = Process.GetProcessesByName($"{programName}");
                    foreach (Process process in processes) {
                        process.Kill();
                        process.WaitForExit();
                        process.Dispose();
                    }
                }
            }
        }
    }
}