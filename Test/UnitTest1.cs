using System;
using EDM;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(IMS_SZEntities db = new IMS_SZEntities())
            {
                var query = db.CRM_Customer.AsNoTracking().Select(x => new
                {
                    Code = x.Code,
                    Name = x.Name
                }).ToList();
            }
        }
    }
}
