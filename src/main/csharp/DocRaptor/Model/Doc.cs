using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DocRaptor.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class Doc :  IEquatable<Doc>
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {

            [EnumMember(Value = "pdf")]
            Pdf,

            [EnumMember(Value = "xls")]
            Xls,

            [EnumMember(Value = "xlsx")]
            Xlsx
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrictEnum {

            [EnumMember(Value = "none")]
            None
        }

        /// <summary>
        /// The kind of document being created.
        /// </summary>
        /// <value>The kind of document being created.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Force strict HTML validation.
        /// </summary>
        /// <value>Force strict HTML validation.</value>
        [DataMember(Name="strict", EmitDefaultValue=false)]
        public StrictEnum? Strict { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Doc" /> class.
        /// Initializes a new instance of the <see cref="Doc" />class.
        /// </summary>
        /// <param name="Pipeline">Specify a specific verison of the DocRaptor Pipeline to use..</param>
        /// <param name="Name">A name for identifying your document..</param>
        /// <param name="Type">The kind of document being created. (required).</param>
        /// <param name="DocumentContent">The HTML data to be transformed into a document. You must supply content using document_content or document_url. (required).</param>
        /// <param name="DocumentUrl">The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url..</param>
        /// <param name="Test">Enable test mode for this document. Test documents are not charged for but include a watermark. (default to true).</param>
        /// <param name="Strict">Force strict HTML validation. (default to StrictEnum.None).</param>
        /// <param name="IgnoreResourceErrors">Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop. (default to true).</param>
        /// <param name="Tag">A field for storing a small amount of metadata with this document..</param>
        /// <param name="Help">Request support help with this request if it succeeds. (default to false).</param>
        /// <param name="Javascript">Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere. (default to false).</param>
        /// <param name="Referrer">Set HTTP referrer when generating this document..</param>
        /// <param name="CallbackUrl">A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status api responses. WARNING: this only works on asynchronous documents..</param>
        /// <param name="PrinceOptions">PrinceOptions.</param>

        public Doc(string Pipeline = null, string Name = null, TypeEnum? Type = null, string DocumentContent = null, string DocumentUrl = null, bool? Test = null, StrictEnum? Strict = null, bool? IgnoreResourceErrors = null, string Tag = null, bool? Help = null, bool? Javascript = null, string Referrer = null, string CallbackUrl = null, PrinceOptions PrinceOptions = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Doc and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "DocumentContent" is required (not null)
            if (DocumentContent == null)
            {
                throw new InvalidDataException("DocumentContent is a required property for Doc and cannot be null");
            }
            else
            {
                this.DocumentContent = DocumentContent;
            }
            this.Pipeline = Pipeline;
            this.Name = Name;
            this.DocumentUrl = DocumentUrl;
            // use default value if no "Test" provided
            if (Test == null)
            {
                this.Test = true;
            }
            else
            {
                this.Test = Test;
            }
            // use default value if no "Strict" provided
            if (Strict == null)
            {
                this.Strict = StrictEnum.None;
            }
            else
            {
                this.Strict = Strict;
            }
            // use default value if no "IgnoreResourceErrors" provided
            if (IgnoreResourceErrors == null)
            {
                this.IgnoreResourceErrors = true;
            }
            else
            {
                this.IgnoreResourceErrors = IgnoreResourceErrors;
            }
            this.Tag = Tag;
            // use default value if no "Help" provided
            if (Help == null)
            {
                this.Help = false;
            }
            else
            {
                this.Help = Help;
            }
            // use default value if no "Javascript" provided
            if (Javascript == null)
            {
                this.Javascript = false;
            }
            else
            {
                this.Javascript = Javascript;
            }
            this.Referrer = Referrer;
            this.CallbackUrl = CallbackUrl;
            this.PrinceOptions = PrinceOptions;

        }


        /// <summary>
        /// Specify a specific verison of the DocRaptor Pipeline to use.
        /// </summary>
        /// <value>Specify a specific verison of the DocRaptor Pipeline to use.</value>
        [DataMember(Name="pipeline", EmitDefaultValue=false)]
        public string Pipeline { get; set; }

        /// <summary>
        /// A name for identifying your document.
        /// </summary>
        /// <value>A name for identifying your document.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                    this.Pipeline == other.Pipeline ||
                    this.Pipeline != null &&
                    this.Pipeline.Equals(other.Pipeline)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                if (this.Pipeline != null)
                    hash = hash * 59 + this.Pipeline.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

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
