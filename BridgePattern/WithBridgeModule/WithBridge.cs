using BridgePattern.WithBridgeModule.ApproachModels;
using BridgePattern.WithBridgeModule.ShootingTypes;

namespace BridgePattern.WithBridgeModule
{
    public class WithBridge
    {
        public static void Execute()
        {
            ApproachModel approachModel = new Overflow(); // Choose the desired approach model

            ShootingType shootingType = new OnModel(approachModel); // Choose the desired shooting type
            shootingType.ExecutePostProduction();
        }
    }
}