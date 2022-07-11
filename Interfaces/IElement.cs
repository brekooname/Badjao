﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IElement : IDataUnit
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        IKey ID { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <returns></returns>
        string Code { get; set; }

        /// <summary>
        /// Gets or sets the initial.
        /// </summary>
        /// <value>
        /// The initial.
        /// </value>
        string Initial { get; set; }
    }
}