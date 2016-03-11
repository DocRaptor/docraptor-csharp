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
    public partial class AsyncDoc :  IEquatable<AsyncDoc>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDoc" /> class.
        /// Initializes a new instance of the <see cref="AsyncDoc" />class.
        /// </summary>
        /// <param name="StatusId">The identifier used to get the status of the document using the status api..</param>

        public AsyncDoc(string StatusId = null)
        {
            this.StatusId = StatusId;

        }


        /// <summary>
        /// The identifier used to get the status of the document using the status api.
        /// </summary>
        /// <value>The identifier used to get the status of the document using the status api.</value>
        [DataMember(Name="status_id", EmitDefaultValue=false)]
        public string StatusId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncDoc {\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");

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
            return this.Equals(obj as AsyncDoc);
        }

        /// <summary>
        /// Returns true if AsyncDoc instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncDoc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncDoc other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
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

                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();

                return hash;
            }
        }

    }
}
