using System;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types
{
    /// <summary>
    /// ServicingPartnerInfoCheckEntity Entity
    /// </summary>
    public class ServicingPartnerInfoCheckEntity
    {
        /// <summary>
        /// Inner Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Request Id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Financing Key
        /// </summary>
        public string ServicingPartnerKey { get; set; }

        /// <summary>
        /// Date of Create
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Determines whether request was succesful
        /// </summary>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// REsponse JSON
        /// </summary>
        public string ResponseJSON { get; set; }

        /// <summary>
        /// Type of the model
        /// </summary>
        public string ModelType { get; set; }

    }
}
