/*
    http://answers.unity.com/answers/1608553/view.html
    
    @arelian11/@AmitSuri
    
    Attach this to a game object in your scene and save the scene. Now every
    time you compile and if you scene is marked dirty it will be detected by
    this code and logged. Click on the logged line in console and it will point
    you the offending gameobject that is marking the scene dirty. Next, check
    the parent of the target game object of grandparent or so on...and if you
    see that it has a scroll rect, fix the floating values on the scroll rect to
    be rounded integers instead of floating values.

*/
public class SceneDirtyFlagChecker : MonoBehaviour  { 
    static SceneDirtyFlagChecker() 
    { 
        Undo.postprocessModifications += OnPostProcessModifications; 
    }
 
    private static UndoPropertyModification[] OnPostProcessModifications(UndoPropertyModification[] propertyModifications) 
    { 
        Debug.LogWarning($"Scene was marked Dirty by number of objects = {propertyModifications.Length}"); 
        for (int i = 0; i < propertyModifications.Length; i++) 
        { 
            Debug.LogWarning($"currentValue.target = {propertyModifications[i].currentValue.target}", propertyModifications[i].currentValue.target); 
        } 
        return propertyModifications; 
    } 
} 