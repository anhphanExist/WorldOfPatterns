using BridgePattern.WithoutBridgeModule.ShootingTypes;

namespace BridgePattern.WithoutBridgeModule;

public class WithoutBridge
{
    public static void Execute()
    {
        ShootingTypeWithoutBridge shootingType = new OnModelWithoutBridge(); // Choose the desired shooting type

        EnumApproachModel enumApproachModel = EnumApproachModel.NoPostProduction;
        shootingType.ExecutePostProduction(enumApproachModel);
    }
}