using System.Threading.Tasks;
using Xunit;
using Verify = CSharpVerifier<Xunit.Analyzers.FactMethodMustNotHaveParameters>;

public class FactMethodMustNotHaveParametersTests
{
	[Fact]
	public async Task DoesNotFindErrorForFactWithNoParameters()
	{
		var source = @"
public class TestClass {
    [Xunit.Fact]
    public void TestMethod() { }
}";

		await Verify.VerifyAnalyzer(source);
	}

	[Fact]
	public async Task DoesNotFindErrorForTheoryWithParameters()
	{
		var source = @"
public class TestClass {
    [Xunit.Theory]
    public void TestMethod(string p) { }
}";

		await Verify.VerifyAnalyzer(source);
	}

	[Fact]
	public async Task FindsErrorForFactWithParameter()
	{
		var source = @"
public class TestClass {
    [Xunit.Fact]
    public void TestMethod(string p) { }
}";
		var expected =
			Verify
				.Diagnostic()
				.WithSpan(4, 17, 4, 27);

		await Verify.VerifyAnalyzer(source, expected);
	}
}
