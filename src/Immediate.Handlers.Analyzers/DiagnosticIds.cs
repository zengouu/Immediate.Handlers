using System.Diagnostics.CodeAnalysis;

namespace Immediate.Handlers.Analyzers;

[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Diagnostic IDs start with IHR")]
internal static class DiagnosticIds
{
	public const string IHR0001HandlerMethodMustExist = "IHR0001";
	public const string IHR0002HandlerMethodMustReturnTask = "IHR0002";
	public const string IHR0003BehaviorsMustNotBeRepeated = "IHR0003";
	public const string IHR0004InvalidRenderMode = "IHR0004";
	public const string IHR0005HandlerClassMustNotBeNested = "IHR0005";
	public const string IHR0006BehaviorsMustInheritFromBehavior = "IHR0006";
	public const string IHR0007BehaviorsMustHaveTwoGenericParameters = "IHR0007";
	public const string IHR0008BehaviorsMustUseUnboundGenerics = "IHR0008";
	public const string IHR0009HandlerMethodMustBeStatic = "IHR0009";
	public const string IHR0010HandlerMethodMustBeUnique = "IHR0010";
}
