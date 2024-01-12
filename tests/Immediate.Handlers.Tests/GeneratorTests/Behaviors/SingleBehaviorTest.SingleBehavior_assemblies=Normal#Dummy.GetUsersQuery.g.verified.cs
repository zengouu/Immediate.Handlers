﻿//HintName: Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed class Handler
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _behavior_0;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _behavior_1;
	
		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior behavior_0,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> behavior_1
		)
		{
			_behavior_0 = behavior_0;
			_behavior_1 = behavior_1;

			_behavior_1.SetInnerHandler(_behavior_0);
		}
	
		public async global::System.Threading.Tasks.Task<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _behavior_1
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
	}

	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.UsersService _usersService;
	
		public HandleBehavior(
			global::Dummy.UsersService usersService
		)
		{
			_usersService = usersService;
		}
	
		public override async global::System.Threading.Tasks.Task<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken
		)
		{
			return await global::Dummy.GetUsersQuery
				.HandleAsync(
					request,                
					_usersService,
					cancellationToken
				)
				.ConfigureAwait(false);
		}
	}
}