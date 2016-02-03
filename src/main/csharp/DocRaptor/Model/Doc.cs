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
    public class Doc :  IEquatable<Doc>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Doc" /> class.
        /// </summary>
        public Doc()
        {
            this.Test = true;
            this.Strict = "none";
            this.IgnoreResourceErrors = true;
            this.Help = false;
            this.Javascript = false;

        }


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
        /// The HTML data to be transformed into a document. You must supply content using document_content or document_url.
        /// </summary>
        /// <value>The HTML data to be transformed into a document. You must supply content using document_content or document_url.</value>
        [DataMember(Name="document_content", EmitDefaultValue=false)]
        public string DocumentContent { get; set; }


        /// <summary>
        /// The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url.
        /// </summary>
        /// <value>The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url.</value>
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
        /// A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status api responses. WARNING: this only works on asynchronous documents.
        /// </summary>
        /// <value>A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status api responses. WARNING: this only works on asynchronous documents.</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }


        /// <summary>
        /// Gets or Sets PrinceOptions
        /// </summary>
        [DataMember(Name="prince_options", EmitDefaultValue=false)]
        public PrinceOptions PrinceOptions { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(obj as Doc);
        }

        /// <summary>
        /// Returns true if Doc instances are equal
        /// </summary>
        /// <param name="other">Instance of Doc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Doc other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DocumentType == other.DocumentType ||
                    this.DocumentType != null &&
                    this.DocumentType.Equals(other.DocumentType)
                ) &&
                (
                    this.DocumentContent == other.DocumentContent ||
                    this.DocumentContent != null &&
                    this.DocumentContent.Equals(other.DocumentContent)
                ) &&
                (
                    this.DocumentUrl == other.DocumentUrl ||
                    this.DocumentUrl != null &&
                    this.DocumentUrl.Equals(other.DocumentUrl)
                ) &&
                (
                    this.Test == other.Test ||
                    this.Test != null &&
                    this.Test.Equals(other.Test)
                ) &&
                (
                    this.Strict == other.Strict ||
                    this.Strict != null &&
                    this.Strict.Equals(other.Strict)
                ) &&
                (
                    this.IgnoreResourceErrors == other.IgnoreResourceErrors ||
                    this.IgnoreResourceErrors != null &&
                    this.IgnoreResourceErrors.Equals(other.IgnoreResourceErrors)
                ) &&
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
                ) &&
                (
                    this.Help == other.Help ||
                    this.Help != null &&
                    this.Help.Equals(other.Help)
                ) &&
                (
                    this.Javascript == other.Javascript ||
                    this.Javascript != null &&
                    this.Javascript.Equals(other.Javascript)
                ) &&
                (
                    this.Referrer == other.Referrer ||
                    this.Referrer != null &&
                    this.Referrer.Equals(other.Referrer)
                ) &&
                (
                    this.CallbackUrl == other.CallbackUrl ||
                    this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(other.CallbackUrl)
                ) &&
                (
                    this.PrinceOptions == other.PrinceOptions ||
                    this.PrinceOptions != null &&
                    this.PrinceOptions.Equals(other.PrinceOptions)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DocumentType != null)
                    hash = hash * 59 + this.DocumentType.GetHashCode();

                if (this.DocumentContent != null)
                    hash = hash * 59 + this.DocumentContent.GetHashCode();

                if (this.DocumentUrl != null)
                    hash = hash * 59 + this.DocumentUrl.GetHashCode();

                if (this.Test != null)
                    hash = hash * 59 + this.Test.GetHashCode();

                if (this.Strict != null)
                    hash = hash * 59 + this.Strict.GetHashCode();

                if (this.IgnoreResourceErrors != null)
                    hash = hash * 59 + this.IgnoreResourceErrors.GetHashCode();

                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();

                if (this.Help != null)
                    hash = hash * 59 + this.Help.GetHashCode();

                if (this.Javascript != null)
                    hash = hash * 59 + this.Javascript.GetHashCode();

                if (this.Referrer != null)
                    hash = hash * 59 + this.Referrer.GetHashCode();

                if (this.CallbackUrl != null)
                    hash = hash * 59 + this.CallbackUrl.GetHashCode();

                if (this.PrinceOptions != null)
                    hash = hash * 59 + this.PrinceOptions.GetHashCode();

                return hash;
            }
        }

    }
}
