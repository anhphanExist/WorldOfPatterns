namespace ReplaceConditionalsWithPolymorphism.Conditionals
{
    public class StepGenerator
    {
        // Client code using conditionals
        public static double GetNextStep(string approachType)
        {
            switch (approachType)
            {
                case "Outsourcing":
                    return 0;
                case "InternalOnly":
                    return 0;
                case "Hybrid":
                    return 0;
                default:
                    throw new ArgumentException("Unsupported approach type.");
            }
        }
    }
}