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
    public partial class PrinceOptions :  IEquatable<PrinceOptions>
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public enum InputEnum {

            [EnumMember(Value = "html")]
            Html,

            [EnumMember(Value = "xml")]
            Xml,

            [EnumMember(Value = "auto")]
            Auto
        }

        /// <summary>
        /// Specify the input format.
        /// </summary>
        /// <value>Specify the input format.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public InputEnum? Input { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrinceOptions" /> class.
        /// Initializes a new instance of the <see cref="PrinceOptions" />class.
        /// </summary>
        /// <param name="Baseurl">Set the baseurl for assets..</param>
        /// <param name="NoXinclude">Disable XML inclusion..</param>
        /// <param name="NoNetwork">Disable network access..</param>
        /// <param name="HttpUser">Set the user for HTTP authentication..</param>
        /// <param name="HttpPassword">Set the password for HTTP authentication..</param>
        /// <param name="HttpProxy">Set the HTTP proxy server..</param>
        /// <param name="HttpTimeout">Set the HTTP request timeout..</param>
        /// <param name="Insecure">Disable SSL verification..</param>
        /// <param name="Media">Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles. (default to &quot;print&quot;).</param>
        /// <param name="NoAuthorStyle">Ignore author stylesheets..</param>
        /// <param name="NoDefaultStyle">Ignore default stylesheets..</param>
        /// <param name="NoEmbedFonts">Disable font embedding in PDFs..</param>
        /// <param name="NoSubsetFonts">Disable font subsetting in PDFs..</param>
        /// <param name="NoCompress">Disable PDF compression..</param>
        /// <param name="Encrypt">Encrypt PDF output..</param>
        /// <param name="KeyBits">Set encryption key size..</param>
        /// <param name="UserPassword">Set the PDF user password..</param>
        /// <param name="OwnerPassword">Set the PDF owner password..</param>
        /// <param name="DisallowPrint">Disallow printing of this PDF..</param>
        /// <param name="DisallowCopy">Disallow copying of this PDF..</param>
        /// <param name="DisallowAnnotate">Disallow annotation of this PDF..</param>
        /// <param name="DisallowModify">Disallow modification of this PDF..</param>
        /// <param name="Debug">Enable Prince debug mode..</param>
        /// <param name="Input">Specify the input format. (default to InputEnum.Html).</param>
        /// <param name="Version">Specify a specific verison of PrinceXML to use..</param>
        /// <param name="Javascript">Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere..</param>
        /// <param name="CssDpi">Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up..</param>
        /// <param name="Profile">In Prince 9.0 and up you can set the PDF profile..</param>

        public PrinceOptions(string Baseurl = null, bool? NoXinclude = null, bool? NoNetwork = null, string HttpUser = null, string HttpPassword = null, string HttpProxy = null, int? HttpTimeout = null, bool? Insecure = null, string Media = null, bool? NoAuthorStyle = null, bool? NoDefaultStyle = null, bool? NoEmbedFonts = null, bool? NoSubsetFonts = null, bool? NoCompress = null, bool? Encrypt = null, int? KeyBits = null, string UserPassword = null, string OwnerPassword = null, bool? DisallowPrint = null, bool? DisallowCopy = null, bool? DisallowAnnotate = null, bool? DisallowModify = null, bool? Debug = null, InputEnum? Input = null, string Version = null, bool? Javascript = null, int? CssDpi = null, string Profile = null)
        {
            this.Baseurl = Baseurl;
            this.NoXinclude = NoXinclude;
            this.NoNetwork = NoNetwork;
            this.HttpUser = HttpUser;
            this.HttpPassword = HttpPassword;
            this.HttpProxy = HttpProxy;
            this.HttpTimeout = HttpTimeout;
            this.Insecure = Insecure;
            // use default value if no "Media" provided
            if (Media == null)
            {
                this.Media = "print";
            }
            else
            {
                this.Media = Media;
            }
            this.NoAuthorStyle = NoAuthorStyle;
            this.NoDefaultStyle = NoDefaultStyle;
            this.NoEmbedFonts = NoEmbedFonts;
            this.NoSubsetFonts = NoSubsetFonts;
            this.NoCompress = NoCompress;
            this.Encrypt = Encrypt;
            this.KeyBits = KeyBits;
            this.UserPassword = UserPassword;
            this.OwnerPassword = OwnerPassword;
            this.DisallowPrint = DisallowPrint;
            this.DisallowCopy = DisallowCopy;
            this.DisallowAnnotate = DisallowAnnotate;
            this.DisallowModify = DisallowModify;
            this.Debug = Debug;
            // use default value if no "Input" provided
            if (Input == null)
            {
                this.Input = InputEnum.Html;
            }
            else
            {
                this.Input = Input;
            }
            this.Version = Version;
            this.Javascript = Javascript;
            this.CssDpi = CssDpi;
            this.Profile = Profile;

        }


        /// <summary>
        /// Set the baseurl for assets.
        /// </summary>
        /// <value>Set the baseurl for assets.</value>
        [DataMember(Name="baseurl", EmitDefaultValue=false)]
        public string Baseurl { get; set; }

        /// <summary>
        /// Disable XML inclusion.
        /// </summary>
        /// <value>Disable XML inclusion.</value>
        [DataMember(Name="no_xinclude", EmitDefaultValue=false)]
        public bool? NoXinclude { get; set; }

        /// <summary>
        /// Disable network access.
        /// </summary>
        /// <value>Disable network access.</value>
        [DataMember(Name="no_network", EmitDefaultValue=false)]
        public bool? NoNetwork { get; set; }

        /// <summary>
        /// Set the user for HTTP authentication.
        /// </summary>
        /// <value>Set the user for HTTP authentication.</value>
        [DataMember(Name="http_user", EmitDefaultValue=false)]
        public string HttpUser { get; set; }

        /// <summary>
        /// Set the password for HTTP authentication.
        /// </summary>
        /// <value>Set the password for HTTP authentication.</value>
        [DataMember(Name="http_password", EmitDefaultValue=false)]
        public string HttpPassword { get; set; }

        /// <summary>
        /// Set the HTTP proxy server.
        /// </summary>
        /// <value>Set the HTTP proxy server.</value>
        [DataMember(Name="http_proxy", EmitDefaultValue=false)]
        public string HttpProxy { get; set; }

        /// <summary>
        /// Set the HTTP request timeout.
        /// </summary>
        /// <value>Set the HTTP request timeout.</value>
        [DataMember(Name="http_timeout", EmitDefaultValue=false)]
        public int? HttpTimeout { get; set; }

        /// <summary>
        /// Disable SSL verification.
        /// </summary>
        /// <value>Disable SSL verification.</value>
        [DataMember(Name="insecure", EmitDefaultValue=false)]
        public bool? Insecure { get; set; }

        /// <summary>
        /// Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles.
        /// </summary>
        /// <value>Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }

        /// <summary>
        /// Ignore author stylesheets.
        /// </summary>
        /// <value>Ignore author stylesheets.</value>
        [DataMember(Name="no_author_style", EmitDefaultValue=false)]
        public bool? NoAuthorStyle { get; set; }

        /// <summary>
        /// Ignore default stylesheets.
        /// </summary>
        /// <value>Ignore default stylesheets.</value>
        [DataMember(Name="no_default_style", EmitDefaultValue=false)]
        public bool? NoDefaultStyle { get; set; }

        /// <summary>
        /// Disable font embedding in PDFs.
        /// </summary>
        /// <value>Disable font embedding in PDFs.</value>
        [DataMember(Name="no_embed_fonts", EmitDefaultValue=false)]
        public bool? NoEmbedFonts { get; set; }

        /// <summary>
        /// Disable font subsetting in PDFs.
        /// </summary>
        /// <value>Disable font subsetting in PDFs.</value>
        [DataMember(Name="no_subset_fonts", EmitDefaultValue=false)]
        public bool? NoSubsetFonts { get; set; }

        /// <summary>
        /// Disable PDF compression.
        /// </summary>
        /// <value>Disable PDF compression.</value>
        [DataMember(Name="no_compress", EmitDefaultValue=false)]
        public bool? NoCompress { get; set; }

        /// <summary>
        /// Encrypt PDF output.
        /// </summary>
        /// <value>Encrypt PDF output.</value>
        [DataMember(Name="encrypt", EmitDefaultValue=false)]
        public bool? Encrypt { get; set; }

        /// <summary>
        /// Set encryption key size.
        /// </summary>
        /// <value>Set encryption key size.</value>
        [DataMember(Name="key_bits", EmitDefaultValue=false)]
        public int? KeyBits { get; set; }

        /// <summary>
        /// Set the PDF user password.
        /// </summary>
        /// <value>Set the PDF user password.</value>
        [DataMember(Name="user_password", EmitDefaultValue=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// Set the PDF owner password.
        /// </summary>
        /// <value>Set the PDF owner password.</value>
        [DataMember(Name="owner_password", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Disallow printing of this PDF.
        /// </summary>
        /// <value>Disallow printing of this PDF.</value>
        [DataMember(Name="disallow_print", EmitDefaultValue=false)]
        public bool? DisallowPrint { get; set; }

        /// <summary>
        /// Disallow copying of this PDF.
        /// </summary>
        /// <value>Disallow copying of this PDF.</value>
        [DataMember(Name="disallow_copy", EmitDefaultValue=false)]
        public bool? DisallowCopy { get; set; }

        /// <summary>
        /// Disallow annotation of this PDF.
        /// </summary>
        /// <value>Disallow annotation of this PDF.</value>
        [DataMember(Name="disallow_annotate", EmitDefaultValue=false)]
        public bool? DisallowAnnotate { get; set; }

        /// <summary>
        /// Disallow modification of this PDF.
        /// </summary>
        /// <value>Disallow modification of this PDF.</value>
        [DataMember(Name="disallow_modify", EmitDefaultValue=false)]
        public bool? DisallowModify { get; set; }

        /// <summary>
        /// Enable Prince debug mode.
        /// </summary>
        /// <value>Enable Prince debug mode.</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }

        /// <summary>
        /// Specify a specific verison of PrinceXML to use.
        /// </summary>
        /// <value>Specify a specific verison of PrinceXML to use.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere.
        /// </summary>
        /// <value>Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere.</value>
        [DataMember(Name="javascript", EmitDefaultValue=false)]
        public bool? Javascript { get; set; }

        /// <summary>
        /// Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up.
        /// </summary>
        /// <value>Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up.</value>
        [DataMember(Name="css_dpi", EmitDefaultValue=false)]
        public int? CssDpi { get; set; }

        /// <summary>
        /// In Prince 9.0 and up you can set the PDF profile.
        /// </summary>
        /// <value>In Prince 9.0 and up you can set the PDF profile.</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public string Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinceOptions {\n");
            sb.Append("  Baseurl: ").Append(Baseurl).Append("\n");
            sb.Append("  NoXinclude: ").Append(NoXinclude).Append("\n");
            sb.Append("  NoNetwork: ").Append(NoNetwork).Append("\n");
            sb.Append("  HttpUser: ").Append(HttpUser).Append("\n");
            sb.Append("  HttpPassword: ").Append(HttpPassword).Append("\n");
            sb.Append("  HttpProxy: ").Append(HttpProxy).Append("\n");
            sb.Append("  HttpTimeout: ").Append(HttpTimeout).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  NoAuthorStyle: ").Append(NoAuthorStyle).Append("\n");
            sb.Append("  NoDefaultStyle: ").Append(NoDefaultStyle).Append("\n");
            sb.Append("  NoEmbedFonts: ").Append(NoEmbedFonts).Append("\n");
            sb.Append("  NoSubsetFonts: ").Append(NoSubsetFonts).Append("\n");
            sb.Append("  NoCompress: ").Append(NoCompress).Append("\n");
            sb.Append("  Encrypt: ").Append(Encrypt).Append("\n");
            sb.Append("  KeyBits: ").Append(KeyBits).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  DisallowPrint: ").Append(DisallowPrint).Append("\n");
            sb.Append("  DisallowCopy: ").Append(DisallowCopy).Append("\n");
            sb.Append("  DisallowAnnotate: ").Append(DisallowAnnotate).Append("\n");
            sb.Append("  DisallowModify: ").Append(DisallowModify).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  CssDpi: ").Append(CssDpi).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");

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
            return this.Equals(obj as PrinceOptions);
        }

        /// <summary>
        /// Returns true if PrinceOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of PrinceOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinceOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Baseurl == other.Baseurl ||
                    this.Baseurl != null &&
                    this.Baseurl.Equals(other.Baseurl)
                ) &&
                (
                    this.NoXinclude == other.NoXinclude ||
                    this.NoXinclude != null &&
                    this.NoXinclude.Equals(other.NoXinclude)
                ) &&
                (
                    this.NoNetwork == other.NoNetwork ||
                    this.NoNetwork != null &&
                    this.NoNetwork.Equals(other.NoNetwork)
                ) &&
                (
                    this.HttpUser == other.HttpUser ||
                    this.HttpUser != null &&
                    this.HttpUser.Equals(other.HttpUser)
                ) &&
                (
                    this.HttpPassword == other.HttpPassword ||
                    this.HttpPassword != null &&
                    this.HttpPassword.Equals(other.HttpPassword)
                ) &&
                (
                    this.HttpProxy == other.HttpProxy ||
                    this.HttpProxy != null &&
                    this.HttpProxy.Equals(other.HttpProxy)
                ) &&
                (
                    this.HttpTimeout == other.HttpTimeout ||
                    this.HttpTimeout != null &&
                    this.HttpTimeout.Equals(other.HttpTimeout)
                ) &&
                (
                    this.Insecure == other.Insecure ||
                    this.Insecure != null &&
                    this.Insecure.Equals(other.Insecure)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) &&
                (
                    this.NoAuthorStyle == other.NoAuthorStyle ||
                    this.NoAuthorStyle != null &&
                    this.NoAuthorStyle.Equals(other.NoAuthorStyle)
                ) &&
                (
                    this.NoDefaultStyle == other.NoDefaultStyle ||
                    this.NoDefaultStyle != null &&
                    this.NoDefaultStyle.Equals(other.NoDefaultStyle)
                ) &&
                (
                    this.NoEmbedFonts == other.NoEmbedFonts ||
                    this.NoEmbedFonts != null &&
                    this.NoEmbedFonts.Equals(other.NoEmbedFonts)
                ) &&
                (
                    this.NoSubsetFonts == other.NoSubsetFonts ||
                    this.NoSubsetFonts != null &&
                    this.NoSubsetFonts.Equals(other.NoSubsetFonts)
                ) &&
                (
                    this.NoCompress == other.NoCompress ||
                    this.NoCompress != null &&
                    this.NoCompress.Equals(other.NoCompress)
                ) &&
                (
                    this.Encrypt == other.Encrypt ||
                    this.Encrypt != null &&
                    this.Encrypt.Equals(other.Encrypt)
                ) &&
                (
                    this.KeyBits == other.KeyBits ||
                    this.KeyBits != null &&
                    this.KeyBits.Equals(other.KeyBits)
                ) &&
                (
                    this.UserPassword == other.UserPassword ||
                    this.UserPassword != null &&
                    this.UserPassword.Equals(other.UserPassword)
                ) &&
                (
                    this.OwnerPassword == other.OwnerPassword ||
                    this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(other.OwnerPassword)
                ) &&
                (
                    this.DisallowPrint == other.DisallowPrint ||
                    this.DisallowPrint != null &&
                    this.DisallowPrint.Equals(other.DisallowPrint)
                ) &&
                (
                    this.DisallowCopy == other.DisallowCopy ||
                    this.DisallowCopy != null &&
                    this.DisallowCopy.Equals(other.DisallowCopy)
                ) &&
                (
                    this.DisallowAnnotate == other.DisallowAnnotate ||
                    this.DisallowAnnotate != null &&
                    this.DisallowAnnotate.Equals(other.DisallowAnnotate)
                ) &&
                (
                    this.DisallowModify == other.DisallowModify ||
                    this.DisallowModify != null &&
                    this.DisallowModify.Equals(other.DisallowModify)
                ) &&
                (
                    this.Debug == other.Debug ||
                    this.Debug != null &&
                    this.Debug.Equals(other.Debug)
                ) &&
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Javascript == other.Javascript ||
                    this.Javascript != null &&
                    this.Javascript.Equals(other.Javascript)
                ) &&
                (
                    this.CssDpi == other.CssDpi ||
                    this.CssDpi != null &&
                    this.CssDpi.Equals(other.CssDpi)
                ) &&
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
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

                if (this.Baseurl != null)
                    hash = hash * 59 + this.Baseurl.GetHashCode();

                if (this.NoXinclude != null)
                    hash = hash * 59 + this.NoXinclude.GetHashCode();

                if (this.NoNetwork != null)
                    hash = hash * 59 + this.NoNetwork.GetHashCode();

                if (this.HttpUser != null)
                    hash = hash * 59 + this.HttpUser.GetHashCode();

                if (this.HttpPassword != null)
                    hash = hash * 59 + this.HttpPassword.GetHashCode();

                if (this.HttpProxy != null)
                    hash = hash * 59 + this.HttpProxy.GetHashCode();

                if (this.HttpTimeout != null)
                    hash = hash * 59 + this.HttpTimeout.GetHashCode();

                if (this.Insecure != null)
                    hash = hash * 59 + this.Insecure.GetHashCode();

                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();

                if (this.NoAuthorStyle != null)
                    hash = hash * 59 + this.NoAuthorStyle.GetHashCode();

                if (this.NoDefaultStyle != null)
                    hash = hash * 59 + this.NoDefaultStyle.GetHashCode();

                if (this.NoEmbedFonts != null)
                    hash = hash * 59 + this.NoEmbedFonts.GetHashCode();

                if (this.NoSubsetFonts != null)
                    hash = hash * 59 + this.NoSubsetFonts.GetHashCode();

                if (this.NoCompress != null)
                    hash = hash * 59 + this.NoCompress.GetHashCode();

                if (this.Encrypt != null)
                    hash = hash * 59 + this.Encrypt.GetHashCode();

                if (this.KeyBits != null)
                    hash = hash * 59 + this.KeyBits.GetHashCode();

                if (this.UserPassword != null)
                    hash = hash * 59 + this.UserPassword.GetHashCode();

                if (this.OwnerPassword != null)
                    hash = hash * 59 + this.OwnerPassword.GetHashCode();

                if (this.DisallowPrint != null)
                    hash = hash * 59 + this.DisallowPrint.GetHashCode();

                if (this.DisallowCopy != null)
                    hash = hash * 59 + this.DisallowCopy.GetHashCode();

                if (this.DisallowAnnotate != null)
                    hash = hash * 59 + this.DisallowAnnotate.GetHashCode();

                if (this.DisallowModify != null)
                    hash = hash * 59 + this.DisallowModify.GetHashCode();

                if (this.Debug != null)
                    hash = hash * 59 + this.Debug.GetHashCode();

                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Javascript != null)
                    hash = hash * 59 + this.Javascript.GetHashCode();

                if (this.CssDpi != null)
                    hash = hash * 59 + this.CssDpi.GetHashCode();

                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();

                return hash;
            }
        }

    }
}
