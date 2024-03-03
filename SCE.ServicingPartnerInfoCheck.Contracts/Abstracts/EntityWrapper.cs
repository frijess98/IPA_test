
namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
	/// <summary>
	/// Entity wrapper
	/// </summary>
	public class EntityWrapper
	{
		/// <summary>
		/// Entity to be processed
		/// </summary>
		public object Entity { get; set; }

		/// <summary>
		/// Infocchecker to be chosen
		/// </summary>
		public string Infocchecker { get; set; }

		private EntityWrapper()
		{

		}

		/// <summary>
		/// Creates an instance of wrapper
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="infocchecker"></param>
		/// <returns></returns>
		public static EntityWrapper Instance(object entity, string infocchecker)
			=> new EntityWrapper
			{
				Entity = entity,
				Infocchecker = infocchecker
			};
	}
}
