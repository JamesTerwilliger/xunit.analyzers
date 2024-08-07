using System;
using Microsoft.CodeAnalysis;

namespace Xunit.Analyzers;

public interface ICoreContext
{
	/// <summary>
	/// Gets a reference to type <c>ClassDataAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? ClassDataAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>CollectionAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? CollectionAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>CollectionDefinitionAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? CollectionDefinitionAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>DataAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? DataAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>FactAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? FactAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>IClassFixture&lt;T&gt;</c>, if available.
	/// </summary>
	INamedTypeSymbol? IClassFixtureType { get; }

	/// <summary>
	/// Gets a reference to type <c>ICollectionFixture&lt;T&gt;</c>, if available.
	/// </summary>
	INamedTypeSymbol? ICollectionFixtureType { get; }

	/// <summary>
	/// Gets a reference to type <c>InlineDataAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? InlineDataAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>ITestOutputHelper</c>, if available.
	/// </summary>
	INamedTypeSymbol? ITestOutputHelperType { get; }

	/// <summary>
	/// Gets a reference to type <c>MemberDataAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? MemberDataAttributeType { get; }

	/// <summary>
	/// Gets a reference to type <c>TheoryAttribute</c>, if available.
	/// </summary>
	INamedTypeSymbol? TheoryAttributeType { get; }

	/// <summary>
	/// Gets a flag indicating whether theory data can be automatically converted from a <see cref="string"/>
	/// value into a <see cref="DateTimeOffset"/> or a <see cref="Guid"/>.
	/// </summary>
	bool TheorySupportsConversionFromStringToDateTimeOffsetAndGuid { get; }

	/// <summary>
	/// Gets a flag indicating whether theory methods support default parameter values.
	/// </summary>
	bool TheorySupportsDefaultParameterValues { get; }

	/// <summary>
	/// Gets a flag indicating whether theory methods support params arrays.
	/// </summary>
	bool TheorySupportsParameterArrays { get; }

	/// <summary>
	/// Gets the version number of the core assembly.
	/// </summary>
	Version Version { get; }
}
