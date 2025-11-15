using BOOSE;

namespace BOOSEapp
{
    /// <summary>
    /// Custom command factory that returns unrestricted drawing commands.
    /// Overrides the default factory to provide enhanced functionality.
    /// </summary>
    public class AppCommandFactory : CommandFactory
    {
        /// <summary>
        /// Creates a new command based on the command type string.
        /// </summary>
        /// <param name="commandType">The BOOSE command keyword.</param>
        /// <returns>An instance of the corresponding command class.</returns>
        public override ICommand MakeCommand(string commandType)
        {
            commandType = commandType.ToLower();

            if (commandType == "circle")
                return new AppCircle();

            if (commandType == "moveto")
                return new AppMoveTo();

            if (commandType == "rect")
                return new AppRect();

            return base.MakeCommand(commandType);
        }
    }
}
