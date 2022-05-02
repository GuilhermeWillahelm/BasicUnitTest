using System;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest_XUnit
{
    [CollectionDefinition("guid collection", DisableParallelization = false)]
    public class GuidGeneratorCollectionDefinition: ICollectionFixture<GuidGenerator> { }

    //public class GuidGeneratorTest : IClassFixture<GuidGenerator>
    [Collection("guid collection")]
    public class GuidGeneratorTest
    {
        private readonly GuidGenerator _generator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTest(ITestOutputHelper output, GuidGenerator generator)
        {
            _output = output;
            _generator = generator;
        }

        [Fact]
        public void TestOne()
        {
            var guid = _generator.RandomGuid;
            _output.WriteLine($"O guid é {guid}");
        }

        [Fact]
        public void TestTwo()
        {
            var guid = _generator.RandomGuid;
            _output.WriteLine($"O guid é {guid}");
        }
    }

    [Collection("guid collection")]
    public class GuidGeneratorTestTwo
    {
        private readonly GuidGenerator _generator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestTwo(ITestOutputHelper output, GuidGenerator generator)
        {
            _output = output;
            _generator = generator;
        }

        [Fact]
        public void TestOne()
        {
            var guid = _generator.RandomGuid;
            _output.WriteLine($"O guid é {guid}");
        }

        [Fact]
        public void TestTwo()
        {
            var guid = _generator.RandomGuid;
            _output.WriteLine($"O guid é {guid}");
        }
    }
}
