// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsteroidStateChangedArgs.cs" company="">
//   
// </copyright>
// <summary>
//   TODO: Update summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MultiplayerGame.EventArgs
{
    using System;

    using MultiplayerGame.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class AsteroidStateChangedArgs : EventArgs
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AsteroidStateChangedArgs"/> class.
        /// </summary>
        /// <param name="asteroid">
        /// The asteroid.
        /// </param>
        public AsteroidStateChangedArgs(Asteroid asteroid)
        {
            this.Asteroid = asteroid;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Asteroid.
        /// </summary>
        public Asteroid Asteroid { get; private set; }

        #endregion
    }
}