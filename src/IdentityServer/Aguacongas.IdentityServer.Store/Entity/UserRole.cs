﻿using System.ComponentModel.DataAnnotations;

namespace Aguacongas.IdentityServer.Store.Entity
{
    /// <summary>
    /// User role
    /// </summary>
    /// <seealso cref="IEntityId" />
    /// <seealso cref="IUserSubEntity" />
    /// <seealso cref="IRoleSubEntity" />
    public class UserRole : IEntityId, IUserSubEntity, IRoleSubEntity
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        [Required]
        public string RoleId { get; set; }
    }
}
