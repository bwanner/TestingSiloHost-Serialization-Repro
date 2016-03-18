using System;
using System.Threading.Tasks;
using ClassLibrary;
using Grains1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.Serialization;
using Orleans.TestingHost;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : TestingSiloHost
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext param)
        {
            SerializationManager.InitializeForTesting(null, true);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Optional. 
            // By default, the next test class which uses TestignSiloHost will
            // cause a fresh Orleans silo environment to be created.
            StopAllSilosIfRunning();
        }


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
