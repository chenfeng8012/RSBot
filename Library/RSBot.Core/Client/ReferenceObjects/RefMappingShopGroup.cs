﻿namespace RSBot.Core.Client.ReferenceObjects
{
    public class RefMappingShopGroup : IReference
    {
        #region Fields

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public byte Service;

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public int Country;

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group;

        /// <summary>
        /// Gets or sets the shop.
        /// </summary>
        /// <value>
        /// The shop.
        /// </value>
        public string Shop;

        #endregion Fields

        public bool Load(ReferenceParser parser)
        {
            //Skip disabled
            if (!parser.TryParseByte(0, out Service) || Service == 0)
                return false;

            parser.TryParseInt(1, out Country);
            parser.TryParseString(2, out Group);
            parser.TryParseString(3, out Shop);

            return true;
        }
    }
}