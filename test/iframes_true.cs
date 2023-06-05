using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;

class SyncTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-iframes.pdf",
      test: true,
      documentContent: "" +
        "<html><body>" +
          "<p>Baseline text</p>" +
          "<iframe src=\"https://docraptor-test-harness.herokuapp.com/public/index.html\"></iframe>" +
        "</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf,
      princeOptions: new PrinceOptions(
        iframes: true
      )
    );

    byte[] document = docraptor.CreateDoc(doc);
    string output_file = Environment.GetEnvironmentVariable("TEST_OUTPUT_DIR") +
      "/" + Environment.GetEnvironmentVariable("TEST_NAME") + "_csharp_" +
      Environment.GetEnvironmentVariable("RUNTIME_ENV") + ".pdf";
    File.WriteAllBytes(output_file, document);

    string command = "pdftotext " + output_file + " -";
    var proc = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = "-c \""+ command + "\"",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        }
    };
    proc.Start();
    string output = proc.StandardOutput.ReadToEnd();
    proc.WaitForExit();

    if(!output.Contains("Test")) {
      Console.WriteLine("output should have contained iframe content: " + output);
      Environment.Exit(1);
    }
  }
}
