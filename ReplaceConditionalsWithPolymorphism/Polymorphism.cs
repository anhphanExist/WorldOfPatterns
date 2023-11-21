namespace ReplaceConditionalsWithPolymorphism.Polymorphism
{
    public abstract class ApproachModel
    {
        public abstract double GetNextStep();
    }

    public class Outsourcing : ApproachModel
    {

        public override double GetNextStep()
        {
            return 0;
        }
    }

    public class InternalOnly : ApproachModel
    {
        public override double GetNextStep()
        {
            return 0;
        }
    }

    public class Hybrid : ApproachModel
    {
        public override double GetNextStep()
        {
            return 0;
        }
    }

    // Using polymorphism to calculate area without conditionals
    public class StepGenerator
    {
        public double GetNextStep(ApproachModel approachModel)
        {
            return approachModel.GetNextStep();
        }
    }

}