namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Interface ILayoutCreator
    /// </summary>
    public interface ILayoutCreator
    {
        /// <summary>
        /// Creates the layout.
        /// </summary>
        /// <param name="layout">The layout.</param>
        /// <returns>ILayout.</returns>
        ILayout CreateLayout(string layout);

    }
}
