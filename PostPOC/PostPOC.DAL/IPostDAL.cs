namespace PostPOC.DAL
{
    /// <summary>
    /// Interface IPostDAL
    /// </summary>
    public interface IPostDAL
    {
        /// <summary>
        /// Queries the detail.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="URL">The URL.</param>
        /// <returns>T.</returns>
        T QueryDetail<T>(string URL);
    }
}
