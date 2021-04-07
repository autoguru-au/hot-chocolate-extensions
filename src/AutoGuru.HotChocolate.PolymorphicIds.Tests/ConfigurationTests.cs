﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace AutoGuru.HotChocolate.PolymorphicIds.Tests
{
    public class PolymorphicIdsSchemaBuilderExtensionsTests
    {
        [Fact]
        public void Should_Throw_If_Null_Builder()
        {
            var ex = Should.Throw<ArgumentNullException>(
                () => PolymorphicIdsSchemaBuilderExtensions.AddPolymorphicIds(null!));
            ex.ParamName.ShouldBe("builder");
        }
    }
}
