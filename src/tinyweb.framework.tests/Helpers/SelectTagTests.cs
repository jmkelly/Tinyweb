using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using tinyweb.framework.Helpers;
using Moq;
using System.Web;
using System.Web.Routing;

namespace tinyweb.framework.tests
{
    [TestFixture] 
    public class SeletTagTests
    {


        //IEnumerable<HandlerData> handlers;

    
        [SetUp]
        public void Setup()
        {
          

            Tinyweb.Handlers = new List<HandlerData>
            {
                new HandlerData {Type = typeof(SampleModelHandler) }
            };

            
        }

       

        [Test]
        public void SelectTag_returns_select_html()
        {
          Assert.AreEqual(Expected(),SelectTag.For<SampleModelHandler>("id","name"));  

        }

        public string Expected()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<select>");
            sb.Append("\n");
            foreach (SampleModel s in new SampleModelHandler().createDummySampleModels())
            {
                sb.Append("\t");
                sb.Append("<option value='" + s.id.ToString() + "'>" + s.name + "</option>");
                sb.Append("\n");
            }
            sb.Append("</select>");
            return sb.ToString();
        }


                
    }

    public class SampleModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class SampleModelHandler
    {
        public IResult Get()
        {

            return new JsonResult(createDummySampleModels());
        }

        public List<SampleModel> createDummySampleModels()
        {
            List<SampleModel> sampleModels = new List<SampleModel>();
            for (int i = 0; i < 10; i++)
            {
                SampleModel sm = new SampleModel { id = i, name = "name" + i.ToString() };
                sampleModels.Add(sm);
            }
            return sampleModels;

        }

       
    }

}
