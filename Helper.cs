namespace VoltorbSolver
{
    internal static class Helper
    {
        public static int ModifyValueAccordingToClickEvent(int value, MouseEventArgs e, int defaultVal = 0, int increment = 1)
        {
            return e.Button switch
            {
                MouseButtons.Left => value + increment,
                MouseButtons.Right => Math.Max(value - increment, 0),
                MouseButtons.Middle => defaultVal,
                _ => value
            };
        }
    }
}
