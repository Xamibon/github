using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XAF
{
    /// <summary>
    /// This class is used to create a system user
    /// </summary>
    public class User
    {
        private String _firstName;
        private String _lastName;
        private int _userID;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="firstName">The firstname of the user.</param>
        /// <param name="lastName">The lastname of the user.</param>
        public User(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User( int userID, String firstName, String lastName)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
        }

        public int UserID
        {
            set
            {
                _userID = value;
            }
            get
            {
                return _userID;
            }
        }

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        /// <value>
        /// The firstname.
        /// </value>
        public String FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        /// <value>
        /// The lastname.
        /// </value>
        public String LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }
    }
}