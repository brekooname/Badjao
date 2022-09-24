﻿namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.PathBase" />
    public class DataPath : PathBase, IPath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPath"/> class.
        /// </summary>
        public DataPath( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="DataPath"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public DataPath( string input ) : base( input )
        {
        }
    }
}
