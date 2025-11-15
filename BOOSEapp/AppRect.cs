using BOOSE;
using System;

namespace BOOSEapp
{
    /// <summary>
    /// Represents an unrestricted rectangle drawing command.
    /// </summary>
    public class AppRect : CommandTwoParameters
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AppRect() : base() { }

        /// <summary>
        /// Executes the unrestricted rectangle drawing operation.
        /// </summary>
        public override void Execute()
        {
            base.Execute();
            try
            {
                int width = int.Parse(Parameters[0]);
                int height = int.Parse(Parameters[1]);
                Canvas.Rect(width, height, false);
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing unrestricted rectangle: " + ex.Message);
            }
        }

        /// <summary>
        /// Validates the rectangle parameters.
        /// </summary>
        public override void CheckParameters(string[] parameters)
        {
            base.CheckParameters(parameters);
        }
    }
}


