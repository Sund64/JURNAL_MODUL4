using System;
using System.Collections.Generic;

public class KodePaket
{
    // Method table-driven to get kode pos by kelurahan
    public static string getKodePaket(string namaPaket)
    {
        if (namaPaket == null) return "Kode paket tidak ditemukan";

        var table = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Basic", "P201" },
            { "Standard", "P202" },
            { "Premium", "P203" },
            { "Unlimited", "P204" },
            { "Gaming", "P205" },
            { "Streaming", "P206" },
            { "Family", "P207" },
            { "Business", "P208" },
            { "Student", "P209" },
            { "Traveler", "P210" }
        };

        if (table.TryGetValue(namaPaket.Trim(), out var kode))
            return kode;

        return "Kode paket tidak ditemukan";
    }
}
