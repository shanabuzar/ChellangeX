//-----------------------------------------------------------------------
// <copyright file="Record.cs" company="DevBatch Ltd">
// Copyright (c) DevBatch Ltd. All rights reserved.
// </copyright>
// <summary>Record class.</summary>
//----------------------------------------------------------------------
using System.Xml.Serialization;

namespace Oxo.Entities.Modals
{
    /// <summary>
    /// Record entity class.
    /// </summary>
    /// <seealso cref="Record" />
    [XmlRoot("Record")]
    public class Record
    {
        /// <summary>
        /// Gets or sets the Question.
        /// </summary>
        /// <value>
        /// The Question.
        /// </value>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the Level.
        /// </summary>
        /// <value>
        /// The Level.
        /// </value>
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the Theme.
        /// </summary>
        /// <value>
        /// The Theme.
        /// </value>
        public string Theme { get; set; }

        /// <summary>
        /// Gets or sets the Bonus.
        /// </summary>
        /// <value>
        /// The Bonus.
        /// </value>
        public int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the ResponseTime.
        /// </summary>
        /// <value>
        /// The ResponseTime.
        /// </value>
        public int ResponseTime { get; set; }

        /// <summary>
        /// Gets or sets the Answers.
        /// </summary>
        /// <value>
        /// The Answers.
        /// </value>
        public Answers Answers { get; set; }
    }
}
