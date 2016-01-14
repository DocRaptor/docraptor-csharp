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
  public class Doc {
    
    /// <summary>
    /// A name for identifying your document.
    /// </summary>
    /// <value>A name for identifying your document.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// The type of document being created.
    /// </summary>
    /// <value>The type of document being created.</value>
    [DataMember(Name="document_type", EmitDefaultValue=false)]
    public string DocumentType { get; set; }

    
    /// <summary>
    /// The HTML data to be transformed into a document.\nYou must supply content using document_content or document_url.
    /// </summary>
    /// <value>The HTML data to be transformed into a document.\nYou must supply content using document_content or document_url.</value>
    [DataMember(Name="document_content", EmitDefaultValue=false)]
    public string DocumentContent { get; set; }

    
    /// <summary>
    /// The URL to fetch the HTML data to be transformed into a document.\nYou must supply content using document_content or document_url.
    /// </summary>
    /// <value>The URL to fetch the HTML data to be transformed into a document.\nYou must supply content using document_content or document_url.</value>
    [DataMember(Name="document_url", EmitDefaultValue=false)]
    public string DocumentUrl { get; set; }

    
    /// <summary>
    /// Enable test mode for this document. Test documents are not charged for but include a watermark.
    /// </summary>
    /// <value>Enable test mode for this document. Test documents are not charged for but include a watermark.</value>
    [DataMember(Name="test", EmitDefaultValue=false)]
    public bool? Test { get; set; }

    
    /// <summary>
    /// Force strict HTML validation.
    /// </summary>
    /// <value>Force strict HTML validation.</value>
    [DataMember(Name="strict", EmitDefaultValue=false)]
    public string Strict { get; set; }

    
    /// <summary>
    /// Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop.
    /// </summary>
    /// <value>Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop.</value>
    [DataMember(Name="ignore_resource_errors", EmitDefaultValue=false)]
    public bool? IgnoreResourceErrors { get; set; }

    
    /// <summary>
    /// A field for storing a small amount of metadata with this document.
    /// </summary>
    /// <value>A field for storing a small amount of metadata with this document.</value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    public string Tag { get; set; }

    
    /// <summary>
    /// Request support help with this request if it succeeds.
    /// </summary>
    /// <value>Request support help with this request if it succeeds.</value>
    [DataMember(Name="help", EmitDefaultValue=false)]
    public bool? Help { get; set; }

    
    /// <summary>
    /// Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere.
    /// </summary>
    /// <value>Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere.</value>
    [DataMember(Name="javascript", EmitDefaultValue=false)]
    public bool? Javascript { get; set; }

    
    /// <summary>
    /// Set HTTP referrer when generating this document.
    /// </summary>
    /// <value>Set HTTP referrer when generating this document.</value>
    [DataMember(Name="referrer", EmitDefaultValue=false)]
    public string Referrer { get; set; }

    
    /// <summary>
    /// A URL that will receive a POST request after successfully completing an asynchronous document.\nThe POST data will include download_url and download_id similar to status api responses.\nWARNING: this only works on asynchronous documents.
    /// </summary>
    /// <value>A URL that will receive a POST request after successfully completing an asynchronous document.\nThe POST data will include download_url and download_id similar to status api responses.\nWARNING: this only works on asynchronous documents.</value>
    [DataMember(Name="callback_url", EmitDefaultValue=false)]
    public string CallbackUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets PrinceOptions
    /// </summary>
    [DataMember(Name="prince_options", EmitDefaultValue=false)]
    public PrinceOptions PrinceOptions { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Doc {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
      
      sb.Append("  DocumentContent: ").Append(DocumentContent).Append("\n");
      
      sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
      
      sb.Append("  Test: ").Append(Test).Append("\n");
      
      sb.Append("  Strict: ").Append(Strict).Append("\n");
      
      sb.Append("  IgnoreResourceErrors: ").Append(IgnoreResourceErrors).Append("\n");
      
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      
      sb.Append("  Help: ").Append(Help).Append("\n");
      
      sb.Append("  Javascript: ").Append(Javascript).Append("\n");
      
      sb.Append("  Referrer: ").Append(Referrer).Append("\n");
      
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
      
      sb.Append("  PrinceOptions: ").Append(PrinceOptions).Append("\n");
      
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
