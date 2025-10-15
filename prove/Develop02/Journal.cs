using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal {
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void DisplayJournal() {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries) {
            Console.WriteLine($"Date: {entry._date:yyyy-MM-dd} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._text}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (Entry entry in _entries) {
                writer.WriteLine($"{entry._date:yyyy-MM-dd}~|~{entry._prompt}~|~{entry._text}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename) {
        _entries.Clear();
        
        if (File.Exists(filename)) {
            string[] lines = File.ReadAllLines(filename);
            
            foreach (string line in lines) {
                string[] parts = line.Split("~|~");
                
                if (parts.Length == 3) {
                    Entry entry = new Entry();
                    entry._date = DateTime.Parse(parts[0]);
                    entry._prompt = parts[1];
                    entry._text = parts[2];
                    
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        } else {
            Console.WriteLine($"File {filename} not found.");
        }
    }

    public void ShowStatistics() {
        Console.WriteLine("\n=== JOURNAL STATISTICS ===");
        
        // Total entries
        Console.WriteLine($"Total entries: {_entries.Count}");
        
        if (_entries.Count > 0) {
            // Entries this month
            var thisMonth = _entries.Where(e => e._date.Month == DateTime.Now.Month && e._date.Year == DateTime.Now.Year).Count();
            Console.WriteLine($"Entries this month: {thisMonth}");
            
            // Last entry
            var lastEntry = _entries.OrderByDescending(e => e._date).First();
            Console.WriteLine($"Last entry: {lastEntry._date:MMM dd, yyyy}");
            
            // Motivational message
            if (_entries.Count >= 7) {
                Console.WriteLine("Great job! You're building a consistent journaling habit!");
            } else if (_entries.Count >= 3) {
                Console.WriteLine("Keep going! You're making progress!");
            } else {
                Console.WriteLine("Start writing to build your journaling habit!");
            }
        } else {
            Console.WriteLine("No entries yet. Start writing your first entry!");
        }
        
        Console.WriteLine("=== END STATISTICS ===");
    }
}