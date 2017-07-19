//-----------------------------------------------------------------------
// <copyright file="Answers.cs" company="DevBatch Ltd">
// Copyright (c) DevBatch Ltd. All rights reserved.
// </copyright>
// <summary>Answers class.</summary>
//-----------------------------------------------------------------------
using System.Xml.Serialization;

namespace Oxo.Entities.Modals
{
    /// <summary>
    /// Answers entity class.
    /// </summary>
    /// <seealso cref="Answers" />
    public class Answers
    {
        /// <summary>
        /// Gets or sets the OptionA.
        /// </summary>
        /// <value>
        /// The OptionA.
        /// </value>
        [XmlElement("Answer")]
        public string OptionA { get; set; }

        /// <summary>
        /// Gets or sets the OptionB.
        /// </summary>
        /// <value>
        /// The OptionB.
        /// </value>
        [XmlElement("Answer")]
        public string OptionB { get; set; }

        /// <summary>
        /// Gets or sets the OptionC.
        /// </summary>
        /// <value>
        /// The OptionC.
        /// </value>
        [XmlElement("Answer")]
        public string OptionC { get; set; }

        /// <summary>
        /// Gets or sets the correctAns.
        /// </summary>
        /// <value>
        /// The correctAns.
        /// </value>
        public string correctAns { get; set; }


    }
}
