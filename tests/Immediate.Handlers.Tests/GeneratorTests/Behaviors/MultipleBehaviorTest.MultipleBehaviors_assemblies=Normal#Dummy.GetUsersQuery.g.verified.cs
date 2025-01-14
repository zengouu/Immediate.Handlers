﻿//HintName: Dummy.GetUsersQuery.g.cs
#pragma warning disable CS1591

namespace Dummy;

partial class GetUsersQuery
{
	public sealed class Handler : global::Immediate.Handlers.Shared.IHandler<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
	{
		private readonly global::Dummy.GetUsersQuery.HandleBehavior _handleBehavior;
		private readonly global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _secondLoggingBehavior1;
		private readonly global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _loggingBehavior1;
		private readonly global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _secondLoggingBehavior;
		private readonly global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _otherBehavior;
		private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _loggingBehavior;

		public Handler(
			global::Dummy.GetUsersQuery.HandleBehavior handleBehavior,
			global::YetAnotherDummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> secondLoggingBehavior1,
			global::YetAnotherDummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> loggingBehavior1,
			global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> secondLoggingBehavior,
			global::YetAnotherDummy.OtherBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> otherBehavior,
			global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> loggingBehavior
		)
		{
			_handleBehavior = handleBehavior;
			_loggingBehavior = loggingBehavior;
			_otherBehavior = otherBehavior;
			_secondLoggingBehavior = secondLoggingBehavior;
			_loggingBehavior1 = loggingBehavior1;
			_secondLoggingBehavior1 = secondLoggingBehavior1;

			_secondLoggingBehavior1.SetInnerHandler(_handleBehavior);
			_loggingBehavior1.SetInnerHandler(_secondLoggingBehavior1);
			_secondLoggingBehavior.SetInnerHandler(_loggingBehavior1);
			_otherBehavior.SetInnerHandler(_secondLoggingBehavior);
			_loggingBehavior.SetInnerHandler(_otherBehavior);
		}

		public async global::System.Threading.Tasks.ValueTask<IEnumerable<global::Dummy.User>> HandleAsync(
			global::Dummy.GetUsersQuery.Query request,
			global::System.Threading.CancellationToken cancellationToken = default
		)
		{
			return await _loggingBehavior
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

		public override async global::System.Threading.Tasks.ValueTask<IEnumerable<global::Dummy.User>> HandleAsync(
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
