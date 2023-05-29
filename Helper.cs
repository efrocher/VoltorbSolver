namespace VoltorbSolver
{
    internal static class Helper
    {
        public static int ModifyValueAccordingToClickEvent(int value, MouseEventArgs e)
        {
            return e.Button switch
            {
                MouseButtons.Left => value + 1,
                MouseButtons.Right => Math.Max(value - 1, 0),
                MouseButtons.Middle => 0,
                _ => value
            };
        }
    }
}
