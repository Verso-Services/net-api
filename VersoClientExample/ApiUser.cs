namespace VersoClientExample
{
    /// <summary>
    /// Super class to handle username and password properties
    /// </summary>
    public class ApiUser
    {
        #region Constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="pUserName">The Articles batch user to be authenticated</param>
        /// <param name="pPassword">The Articles batch user password to authenticate</param>
        public ApiUser(string pUserName, string pPassword)
        {
            UserName = pUserName;
            Password = pPassword;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Handles the Username to be authenticated
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Handles the user password to be validated
        /// </summary>
        public string Password { get; set; }

        #endregion
    }
}
