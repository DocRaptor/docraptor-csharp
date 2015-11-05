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
  public class PrinceOptions {
    
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
    /// Specify the CSS media type. Defaults to \"print\" but you may want to use \"screen\" for web styles.
    /// </summary>
    /// <value>Specify the CSS media type. Defaults to \"print\" but you may want to use \"screen\" for web styles.</value>
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
    /// Specify the input format.
    /// </summary>
    /// <value>Specify the input format.</value>
    [DataMember(Name="input", EmitDefaultValue=false)]
    public string Input { get; set; }

    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
      
      sb.Append("  Input: ").Append(Input).Append("\n");
      
      sb.Append("  Version: ").Append(Version).Append("\n");
      
      sb.Append("  Javascript: ").Append(Javascript).Append("\n");
      
      sb.Append("  CssDpi: ").Append(CssDpi).Append("\n");
      
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      
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
