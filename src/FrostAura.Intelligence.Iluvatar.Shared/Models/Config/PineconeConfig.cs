﻿using System.Diagnostics;

namespace FrostAura.Intelligence.Iluvatar.Shared.Models.Config
{
    /// <summary>
    /// The Pinecone API configuration model.
    /// </summary>
    [DebuggerDisplay("{ApiEndpoint}")]
	public class PineconeConfig
	{
		/// <summary>
		/// The Pinecone region / environment.
		/// </summary>
		public string Environment { get; set; }
        /// <summary>
        /// The API key to use to auth.
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// The name of the index to use.
        /// </summary>
        public string IndexName { get; set; }
        /// <summary>
        /// The namespace to persist memories to and read from.
        /// </summary>
        public string Namespace { get; set; }
    }
}
