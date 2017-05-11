namespace Invoca.Core.Model.Network.Advertiser
{
    public class User
    {
        /// <summary>
        /// string	The network id for this User.
        /// </summary>
        public string IdFromNetwork { get; set; }

        /// <summary>
        /// string in RFC 2822 addr-spec format	The user’s email address. Unique for this user.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// string (Required)	The user’s first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// string in ITU E.164 format or 10-digit US form (no punctuation)	The user’s phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// string (Required)	The user’s last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// One of: Super (default), Manager, Member, Observer	This user’s role in this organization. (A user may have different roles in different organizations)
        /// </summary>
        public string Role { get; set; }
        public string OauthRefreshToken { get; set; }
    }

}
