using BOOSE;
using System;

namespace BOOSEapp
{
    /// <summary>
    /// Represents an unrestricted circle drawing command.
    /// </summary>
    public class AppCircle : CommandOneParameter
    {
        private int radius;

        /// <summary>
        /// Default constructor for the Circle command.
        /// </summary>
        public AppCircle() : base() { }

        /// <summary>
        /// Executes the unrestricted circle drawing operation.
        /// </summary>
        public override void Execute()
        {
            base.Execute();
            try
            {
                radius = int.Parse(Parameters[0]);
                Canvas.Circle(radius, false);
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing unrestricted circle: " + ex.Message);
            }
        }

        /// <summary>
        /// Validates the parameters for the circle command.
        /// </summary>
        public override void CheckParameters(string[] parameters)
        {
            base.CheckParameters(parameters);
        }
    }
}

