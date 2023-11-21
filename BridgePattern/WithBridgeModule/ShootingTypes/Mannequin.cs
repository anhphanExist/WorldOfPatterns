namespace BridgePattern.WithBridgeModule.ShootingTypes
{
    class Mannequin : ShootingType
    {
        private float side;

        public Mannequin(float side, ApproachModels.ApproachModel approachModel) : base(approachModel)
        {
            this.side = side;
        }

        public override void ExecutePostProduction()
        {
            ApproachModel.GetFlowOptions();
            Console.WriteLine("Execute post production from On Model");
        }
    }
}