﻿namespace ServiceSubstraction_v2
{
    using CalculationRequestParser;
    using ServiceBase;
    using ServiceBootstrapper;

    public class Startup : StartupBase
    {
        // Entry point for the application.
        public static void Main(string[] args) => ServiceBootstrapper.Main(CalculationOperation.Substraction, "2.0", args);        
    }
}
