using Microsoft.CodeAnalysis;

namespace Xunit.Analyzers;

/// <summary>
/// Base class for diagnostic analyzers which support xUnit.net v2 only.
/// </summary>
public abstract class XunitV2DiagnosticAnalyzer(params DiagnosticDescriptor[] descriptors) :
	XunitDiagnosticAnalyzer(descriptors)
{
	protected override bool ShouldAnalyze(XunitContext xunitContext) =>
		Guard.ArgumentNotNull(xunitContext).HasV2References;
}
