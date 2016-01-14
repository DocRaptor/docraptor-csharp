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
  public class AsyncDoc {
    
    /// <summary>
    /// The identifier used to get the status of the document using the status api.
    /// </summary>
    /// <value>The identifier used to get the status of the document using the status api.</value>
    [DataMember(Name="status_id", EmitDefaultValue=false)]
    public string StatusId { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AsyncDoc {\n");
      
      sb.Append("  StatusId: ").Append(StatusId).Append("\n");
      
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
