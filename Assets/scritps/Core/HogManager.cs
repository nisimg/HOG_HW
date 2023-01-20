namespace HOGcore
{


    public class HogManager
    {
        public static HogManager Instance;

        public HogManager()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }



    }
}