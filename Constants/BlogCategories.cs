namespace AbbiePortfolio.Constants;

public record struct BlogCategories
{

    public record struct Categories
    {
        // OOP, Data Structures & Algorithms, .NET, Patterns & Practices
        public const string Fundamentals = "Fundamentals";

        //System Design, Databases, DevOps & Infrastructure
        public const string Architecture = "Architecture";

        //Testing, Security, Performance & Optimization
        public const string QualityAssurance = "Quality Assurance";

        //Soft Skills, Tools
        public const string ToolsAndSkills = "Tools & Skills";

        //UX & UI Principles
        public const string Design = "Design";

        public const string Resources = "Resources";
    }

    public record struct SubCategories
    {
        public const string DataStructuresAndAlgorithms = "Data Structures & Algorithms";
        public const string Databases = "Databases";
        public const string DevOpsAndInfrastructure = "DevOps & Infrastructure";
        public const string DotNet = ".NET";
        public const string Oop = "OOP";
        public const string PatternsAndPractices = "Patterns & Practices";
        public const string PerformanceAndOptimization = "Performance & Optimization";
        public const string Security = "Security";
        public const string SoftSkills = "Soft Skills";
        public const string SystemDesign = "System Design";
        public const string Testing = "Testing";
        public const string Tools = "Tools";
        public const string UxAndUi = "UX & UI Principles";
    }
}
