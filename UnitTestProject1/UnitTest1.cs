using System;
using System.Threading.Tasks;
using ClassLibrary;
using Grains1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.TestingHost;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : TestingSiloHost
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var grain = GrainFactory.GetGrain<IGenericGrain<CustomObject>>(Guid.NewGuid());
            var x = await grain.Get();
        }
        [TestMethod]
        public async Task TestMethod2()
        {
            var grain = GrainFactory.GetGrain<IGenericGrain<CustomObject>>(Guid.NewGuid());
            var x = await grain.Get();
        }

        [TestMethod]
        public async Task TestMethod3()
        {
            var grain = GrainFactory.GetGrain<IGenericGrain<CustomObject>>(Guid.NewGuid());
            var x = await grain.Get();
        }

        [TestMethod]
        public async Task TestMethod4()
        {
            var grain = GrainFactory.GetGrain<IGenericGrain<CustomObject>>(Guid.NewGuid());
            var x = await grain.Get();
        }

        [TestMethod]
        public async Task TestMethod5()
        {
            var grain = GrainFactory.GetGrain<IGenericGrain<CustomObject>>(Guid.NewGuid());
            var x = await grain.Get();
        }
    }
}
