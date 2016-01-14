using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocRaptor.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AsyncDocStatus {
    
    /// <summary>
    /// The present status of the document. Can be queued, working, completed, and failed.
    /// </summary>
    /// <value>The present status of the document. Can be queued, working, completed, and failed.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// The URL where the document can be retrieved. This URL may only be used a few times.
    /// </summary>
    /// <value>The URL where the document can be retrieved. This URL may only be used a few times.</value>
    [DataMember(Name="download_url", EmitDefaultValue=false)]
    public string DownloadUrl { get; set; }

    
    /// <summary>
    /// The identifier for downloading the document with the download api.
    /// </summary>
    /// <value>The identifier for downloading the document with the download api.</value>
    [DataMember(Name="download_id", EmitDefaultValue=false)]
    public string DownloadId { get; set; }

    
    /// <summary>
    /// Additional information.
    /// </summary>
    /// <value>Additional information.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Number of PDF pages in document.
    /// </summary>
    /// <value>Number of PDF pages in document.</value>
    [DataMember(Name="number_of_pages", EmitDefaultValue=false)]
    public int? NumberOfPages { get; set; }

    
    /// <summary>
    /// Error information.
    /// </summary>
    /// <value>Error information.</value>
    [DataMember(Name="validation_errors", EmitDefaultValue=false)]
    public string ValidationErrors { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AsyncDocStatus {\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      
      sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  NumberOfPages: ").Append(NumberOfPages).Append("\n");
      
      sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
