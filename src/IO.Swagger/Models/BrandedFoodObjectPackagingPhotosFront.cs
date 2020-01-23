/*
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// An object containing photos of the front of this item&#x27;s packaging
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectPackagingPhotosFront : IEquatable<BrandedFoodObjectPackagingPhotosFront>
    { 
        /// <summary>
        /// Small photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Small photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="small")]
        public string Small { get; set; }

        /// <summary>
        /// Thumbnail photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Thumbnail photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// Full-sized photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Full-sized photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="display")]
        public string Display { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectPackagingPhotosFront {\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectPackagingPhotosFront)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectPackagingPhotosFront instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectPackagingPhotosFront to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectPackagingPhotosFront other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Small == other.Small ||
                    Small != null &&
                    Small.Equals(other.Small)
                ) && 
                (
                    Thumb == other.Thumb ||
                    Thumb != null &&
                    Thumb.Equals(other.Thumb)
                ) && 
                (
                    Display == other.Display ||
                    Display != null &&
                    Display.Equals(other.Display)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Small != null)
                    hashCode = hashCode * 59 + Small.GetHashCode();
                    if (Thumb != null)
                    hashCode = hashCode * 59 + Thumb.GetHashCode();
                    if (Display != null)
                    hashCode = hashCode * 59 + Display.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectPackagingPhotosFront left, BrandedFoodObjectPackagingPhotosFront right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectPackagingPhotosFront left, BrandedFoodObjectPackagingPhotosFront right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
