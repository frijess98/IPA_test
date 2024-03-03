using System;
using System.Threading.Tasks;
using Qcentris.EventSourcing.Core.Messages;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;
using SCE.ServicingPartnerInfoCheck.Contracts.Constants;

namespace SCE.ServicingPartnerInfoCheck.Services.SpInfoCheckers
{
	/// <summary>
	/// PostFinance InfoChecker
	/// </summary>
	public class PfInfoChecker : IInfoChecker
	{
		private readonly Func<object, Task<RequestExportBase>> mapper;

		/// <summary>
		/// Default key of current SP
		/// </summary>
		public string ServicingPartner => ServicingPartners.PostFinance;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="mapper">Mapper which will do mapping</param>
		public PfInfoChecker(Func<object, Task<RequestExportBase>> mapper)
		{
			this.mapper = mapper;
		}

		/// <summary>
		/// Performing request send to external service (PostFinance)
		/// </summary>
		/// <param name="entity">Entity to be sent</param>
		/// <returns></returns>
		public async Task<IExecutionResult> CheckAsync(object entity)
		{
			var dto = await mapper(entity);

			return await SendAsync(dto);
		}

		/// <summary>
		/// PostFinance does not support
		/// UNDONE: refactoring is needed
		/// </summary>
		/// <param name="requestDto"></param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public Task<IExecutionResult> FetchAsync(object requestDto) => throw new System.NotImplementedException();

		private async Task<IExecutionResult> SendAsync(RequestExportBase mappedMortgage)
		{
			return ExecutionResult.Success;
		}
	}
}
