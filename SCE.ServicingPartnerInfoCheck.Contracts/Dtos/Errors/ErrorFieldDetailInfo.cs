namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Errors
{
    /// <summary>
    /// Detail information regarding field where we have error
    /// </summary>
    public class ErrorFieldDetailInfo
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Current field value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Current error
        /// </summary>
        public string Message { get; set; }
    }
}
