namespace BridgePattern.WithBridgeModule.ShootingTypes
{
    abstract class ShootingType
    {
        protected ApproachModels.ApproachModel ApproachModel;

        public ShootingType(ApproachModels.ApproachModel approachModel)
        {
            this.ApproachModel = approachModel;
        }

        public abstract void ExecutePostProduction();
    }
}