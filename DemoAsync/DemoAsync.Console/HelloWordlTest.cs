using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoAsync.Console
{
    public class HelloWordlTest
    {
        private readonly ITestOutputHelper _output;

        public HelloWordlTest(ITestOutputHelper _output)
        {
            this._output = _output;
        }
        
        [Fact]
        public void HolaMundoAsincronico()
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                _output.WriteLine("Hello World (Async) Thread 2!");
            });

            _output.WriteLine("Hello World Thread 1!");

        }
    }
}
