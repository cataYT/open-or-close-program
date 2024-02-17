using System.Diagnostics;
class MainProgram {
    public static void Main(string[] args) {
        Console.Write("O or C: ");
        string? input = Console.ReadLine();
        if (input != null) {
            if (input.ToLower() == "o") {
                Process.Start("C:\\Program Files\\Notepad++\\notepad++.exe");
            } else if (input.ToLower() == "c") {
                Process[] processes = Process.GetProcessesByName("notepad++");
                foreach (Process process in processes) {
                    process.Kill();
                    process.WaitForExit();
                    process.Dispose();
                }
            }
        }
    }
}