
namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// This class is responsable for store affiliation's information.
    /// </summary>
    public class Security
    {
        /// <summary>
        /// Affiliation property.
        /// </summary>
        public string Affiliation { get; set; }

        /// <summary>
        /// Password property.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Environment property.
        /// </summary>
        public EnvironmentType Environment { get; set; }

        /// <summary>
        /// The environment which will connect.
        /// </summary>
        /// <param name="affiliation">affiliation.</param>
        /// <param name="password">password.</param>
        /// <param name="environment">environment.</param>
        public Security(string affiliation, string password, EnvironmentType environment)
        {
            Affiliation = affiliation;
            Password = password;
            Environment = environment;
        }
    }
}
