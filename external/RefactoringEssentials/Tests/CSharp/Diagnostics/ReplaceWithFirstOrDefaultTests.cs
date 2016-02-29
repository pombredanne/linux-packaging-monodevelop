using NUnit.Framework;
using RefactoringEssentials.CSharp.Diagnostics;

namespace RefactoringEssentials.Tests.CSharp.Diagnostics
{
    [TestFixture]
    public class ReplaceWithFirstOrDefaultTests : CSharpDiagnosticTestBase
    {
        [Test]
        public void TestBasicCase()
        {
            Analyze<ReplaceWithFirstOrDefaultAnalyzer>(@"using System.Linq;
class Bar
{
    public void FooBar(string[] args)
    {
        var first = $args.Any() ? args.First() : null$;
    }
}", @"using System.Linq;
class Bar
{
    public void FooBar(string[] args)
    {
        var first = args.FirstOrDefault();
    }
}");
        }

        [Test]
        public void TestBasicCaseWithExpression()
        {
            Analyze<ReplaceWithFirstOrDefaultAnalyzer>(@"using System.Linq;
class Bar
{
    public void FooBar(string[] args)
    {
        $args.Any(a => a != null) ? args.First(a => a != null) : null$;
    }
}", @"using System.Linq;
class Bar
{
    public void FooBar(string[] args)
    {
        args.FirstOrDefault(a => a != null);
    }
}");
        }

        [Test]
        public void TestBasicCaseWithDefault()
        {
            Analyze<ReplaceWithFirstOrDefaultAnalyzer>(@"using System.Linq;
class Bar
{
	public void FooBar<T>(T[] args)
	{
		var first = $args.Any() ? args.First() : default(T)$;
	}
}", @"using System.Linq;
class Bar
{
	public void FooBar<T>(T[] args)
	{
		var first = args.FirstOrDefault();
	}
}");
        }

        [Test]
        public void TestDisable()
        {
            Analyze<ReplaceWithFirstOrDefaultAnalyzer>(@"using System.Linq;
class Bar
{
	public void FooBar(string[] args)
	{
#pragma warning disable " + CSharpDiagnosticIDs.ReplaceWithFirstOrDefaultAnalyzerID + @"
		var first = args.Any() ? args.First() : null;
	}
}");
        }
    }
}

