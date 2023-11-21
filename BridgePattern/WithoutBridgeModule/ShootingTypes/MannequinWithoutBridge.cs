namespace BridgePattern.WithoutBridgeModule.ShootingTypes
{
    public class MannequinWithoutBridge : ShootingTypeWithoutBridge
    {
        public override void ExecutePostProduction(EnumApproachModel enumApproachModel)
        {
            if (enumApproachModel == EnumApproachModel.Overflow)
            {
                Console.WriteLine($"Flow Options For Overflow");
            }
            else if (enumApproachModel == EnumApproachModel.NoPostProduction)
            {
                Console.WriteLine($"Flow Options For No Post");
            }
            Console.WriteLine("Execute post production from Mannequin");
        }
    }
}