// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Asteroid.cs" company="">
//   
// </copyright>
// <summary>
//   TODO: Update summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MultiplayerGame.Entities
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Asteroid : Sprite
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Asteroid"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="texture">
        /// The texture.
        /// </param>
        /// <param name="initialFrame">
        /// The initial frame.
        /// </param>
        /// <param name="frameCount">
        /// The frame count.
        /// </param>
        /// <param name="collisionRadius">
        /// The collision radius.
        /// </param>
        /// <param name="simulationState">
        /// The simulation state.
        /// </param>
        internal Asteroid(
            long id, 
            Texture2D texture, 
            Rectangle initialFrame, 
            int frameCount, 
            int collisionRadius, 
            EntityState simulationState)
            : base(id, texture, initialFrame, frameCount, collisionRadius, simulationState)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The reset asteroid state.
        /// </summary>
        /// <param name="newState">
        /// The new state.
        /// </param>
        public void ResetAsteroidState(EntityState newState)
        {
            this.SimulationState = newState;
            this.DisplayState = (EntityState)this.SimulationState.Clone();
            this.PrevDisplayState = (EntityState)this.SimulationState.Clone();
        }

        #endregion
    }
}