# Unity Tips And Tricks

These little known tips and tricks that are helpful when using Unity (2018/2019).

1. alt + shift + right-click then move your mouse around in the editor scene view allows you to zoom in and out faster in the scene view.

2. Although you can drag folders and place them into the Favorites section in the Project window, the folders you add there persist between projects and it is only useful to do this whole process if you are working on only one project. Do not click on the Favorites folders you have added when using other projects.

3. If your scene view UI prefab does not sync (this means that the position of the UI elements are in the wrong place) with the prefab view, make sure that the latest prefab is saved somewhere, then delete the prefab in the scene, and then replace it with the saved prefab.

4. Avoid using layout groups and use anchors instead. You can use layout groups first then delete them later. Using layout groups causes problems with saving in the editor.

5. Use multiple canvases for your UIs instead of only one canvas.

6. Canvas groups have an alpha option. You don't need to roll out your own.

7. You can roll out your own health/energy bars quite easily without using UI sliders.

8. There is a Native Unity Editor UI option to reset transforms.

9. Animations can be renamed by double-clicking (I don't remember where). If you rename animations wrongly, it is a pain to rename all the links. Don't forget that Unity does not do linking/syncing for you yet with regards to animation names/animator. Check your prefab/GameObject names and their animation names carefully.

10. To have your RayCasts affect trigger colliders, go to: Edit > Project Settings... > Physics2D and check "Queries Hit Triggers".

11. Physics2D.IgnoreCollision

12. Pseudo-3D raycast calls: Physics2D.GetRayIntersectionAll

13. Physics2D.OverlapPointAll

14. https://docs.microsoft.com/en-us/windows/mixed-reality/performance-recommendations-for-unity

15. It is better to use `nameof` for InvokeRepeating() calls. E.g. `InvokeRepeating(nameof(YourRepeatingMethod), 0f, 0.1f);` than a string.
Similarly, for coroutines, it is better to call the coroutine in `StartCoroutine()` rather than using a method name string. E.g. `StartCoroutine(SetButtons());`

When I remember or find any others, I'll add them here.
