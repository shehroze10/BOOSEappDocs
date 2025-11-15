using BOOSE;
using System;

namespace BOOSEapp
{
    /// <summary>
    /// Represents an unrestricted MoveTo command.
    /// Moves the drawing cursor without coordinate restrictions.
    /// </summary>
    public class AppMoveTo : CommandTwoParameters
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AppMoveTo() : base() { }

        /// <summary>
        /// Executes the MoveTo command.
        /// </summary>
        public override void Execute()
        {
            base.Execute();
            try
            {
                int x = int.Parse(Parameters[0]);
                int y = int.Parse(Parameters[1]);
                Canvas.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing unrestricted moveto: " + ex.Message);
            }
        }

        /// <summary>
        /// Validates the parameters for MoveTo.
        /// </summary>
        public override void CheckParameters(string[] parameters)
        {
            base.CheckParameters(parameters);
        }
    }
}


