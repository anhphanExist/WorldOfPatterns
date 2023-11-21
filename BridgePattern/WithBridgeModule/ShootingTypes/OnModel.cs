using BridgePattern.WithBridgeModule.ApproachModels;

namespace BridgePattern.WithBridgeModule.ShootingTypes
{
    class OnModel : ShootingType
    {
        public OnModel(ApproachModel approachModel) : base(approachModel)
        {
        }

        public override void ExecutePostProduction()
        {
            ApproachModel.GetFlowOptions();
            Console.WriteLine("Execute post production from On Model");
        }
    }
}