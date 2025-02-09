using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cvapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cvapi.Models.Civitai.Images;
using Cvapi.Models.Civitai.Models;

namespace Cvapi.Tests
{
    [TestClass()]
    public class CivitaiClientTests
    {
        [TestMethod()]
        public async Task ModelSearchTest()
        {

            CvsModelSearchM tmp = new CvsModelSearchM()
            {
                Limit = 100
            };

            CivitaiClient client = new CivitaiClient();

            var ret = await client.ModelSearch(tmp.RequestQuery);

            Assert.AreEqual(100, ret.Items.Count);

        }

        [TestMethod()]
        public async Task ImageSearchTest()
        {
            CvsImageSearchM tmp = new CvsImageSearchM() { Limit = 100 };

            CivitaiClient client = new CivitaiClient();
            var ret = await client.ImageSearch(tmp);
            Assert.AreEqual(100, ret.Items.Count);
        }
    }
}