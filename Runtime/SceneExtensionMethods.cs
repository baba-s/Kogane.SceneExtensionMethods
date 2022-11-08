using System.Linq;
using UnityEngine.SceneManagement;

namespace Kogane
{
    public static class SceneExtensionMethods
    {
        public static T[] GetComponentsInChildren<T>( this Scene self )
        {
            return self.GetComponentsInChildren<T>( false );
        }

        public static T[] GetComponentsInChildren<T>( this Scene self, bool includeInactive )
        {
            return self
                    .GetRootGameObjects()
                    .SelectMany( x => x.GetComponentsInChildren<T>( includeInactive ) )
                    .ToArray()
                ;
        }
    }
}