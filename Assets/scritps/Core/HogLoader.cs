using UnityEngine;

namespace HOGcore
{
    
    public class HogLoader : MonoBehaviour
    {
        private void Start()
        {
            Invoke(nameof(Init), 0.1f);
        }

        public void Init()
        {
            new HogManager();
            Destroy(this.gameObject);
        }
    }
}