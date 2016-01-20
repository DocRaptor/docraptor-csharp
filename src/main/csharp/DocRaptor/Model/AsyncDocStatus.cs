using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocRaptor.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AsyncDocStatus :  IEquatable<AsyncDocStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDocStatus" /> class.
        /// </summary>
        public AsyncDocStatus()
        {
            
        }

        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AsyncDocStatus);
        }

        /// <summary>
        /// Returns true if AsyncDocStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncDocStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncDocStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) && 
                (
                    this.DownloadId == other.DownloadId ||
                    this.DownloadId != null &&
                    this.DownloadId.Equals(other.DownloadId)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.NumberOfPages == other.NumberOfPages ||
                    this.NumberOfPages != null &&
                    this.NumberOfPages.Equals(other.NumberOfPages)
                ) && 
                (
                    this.ValidationErrors == other.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.Equals(other.ValidationErrors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                
                if (this.DownloadId != null)
                    hash = hash * 59 + this.DownloadId.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.NumberOfPages != null)
                    hash = hash * 59 + this.NumberOfPages.GetHashCode();
                
                if (this.ValidationErrors != null)
                    hash = hash * 59 + this.ValidationErrors.GetHashCode();
                
                return hash;
            }
        }

    }
}
