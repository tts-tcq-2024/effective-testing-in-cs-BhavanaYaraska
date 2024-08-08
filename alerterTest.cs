using System;

namespace AlerterTest {
    class Program {
        static void Main(string[] args) {
            AlerterSpace.Alerter.SetNetworkAlertFunction((celcius) => {
                // Simulate failure
                return 500;
            });

             method to test failure counting
            AlerterSpace.Alerter.Main(args);           
        }
    }
}
