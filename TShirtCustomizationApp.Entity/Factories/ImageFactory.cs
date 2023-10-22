namespace TShirtCustomizationApp.Entity.Factories
{
    public static class ImageFactory
    {
        public static Image CreateImageInstance(int itemId, int colorId, int fabricId, string image64)
        {
            return new Image(itemId, colorId, fabricId, image64);
        }
    }
}
