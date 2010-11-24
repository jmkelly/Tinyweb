﻿using System.Linq;
using NUnit.Framework;

namespace tinyweb.framework.tests
{
    [TestFixture]
    public class DefaultHandlerScannerTests
    {
        IHandlerScanner defaultHandlerScanner;

        [SetUp]
        public void Setup()
        {
            defaultHandlerScanner = new DefaultHandlerScanner();
        }

        [Test]
        public void FindAll_WhenCalled_FindsThreeHandlers()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Count(), Is.EqualTo(4));
        }

        [Test]
        public void FindAll_WhenCalled_FirstHandlerTypeIsResource1Handler()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Any(h => h.Type == new Resource1Handler().GetType()));
        }

        [Test]
        public void FindAll_WhenCalled_FirstHandlerUriIsCorrect()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Single(h => h.Type == new Resource1Handler().GetType()).Uri == "resource1");
        }

        [Test]
        public void FindAll_WhenCalled_SecondHandlerTypeIsResource2Handler()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Any(h => h.Type == new Resource2Handler().GetType()));
        }

        [Test]
        public void FindAll_WhenCalled_SecondHandlerUriIsCorrect()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Single(h => h.Type == new Resource2Handler().GetType()).Uri == "resource2");
        }

        [Test]
        public void FindAll_WhenCalled_ThirdHandlerTypeIsResource3Handler()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Any(h => h.Type == new Resource3Handler().GetType()));
        }

        [Test]
        public void FindAll_WhenCalled_ThirdHandlerUriIsCorrect()
        {
            var handlers = defaultHandlerScanner.FindAll();
            Assert.That(handlers.Single(h => h.Type == new Resource3Handler().GetType()).Uri == "resource3");
        }
    }
}