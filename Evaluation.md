# Evaluation

From my perspective, this game is a really good base for a Match 3 game, with good basic mechanics and a solid foundation.
Although there are some performance issues and coupling issues, though could harm the scaling of the game, could be improved.
Despite that, the game is still a good starting point.

# Disadvantage
- Item class is hard to debug. This is because it is a pure C# class, with extra View gameObject to display the model.

- Usage of Resource.Load() and string-based asset loading. This is known to be very slow compare to direct referencing 
through ScriptableObject or Prefabs, sometimes a missing character in the name can cause the reference in the game to crash.

- Usage of Singleton pattern. Singleton pattern is known to be hard to test and can cause performance issue.
  
- Code coupling is very tight. The UI require many layer.
  
- Folder structure is not strong. This is the ceveat of the Advantages. There is 2 folder nammed Utility and Util which can confuse developers.
  
- Usage of Update() for checking the board. This can be performance heavy, especially when the board is large.
  
- Usage of multiple prefabs for the same item/preset with the same purpose. Can be put into 1 single Prefab and uses ScriptableObject to store the data.

# Advantage
- Allow the dev to use GameSettings as a way to seperated data for easier debugging. This can benefit switching between different data to test
  
- Well-written code: strong convention, reusable codes and usage of inheritance in several cases
  
- Usage of Extension and Util class to improve reusability of the code.
  
- Folder structure is clear and easy to navigate. (With some caveat)

# Suggestion
- Before Letting the game load Resources, it should be checked if the resources are already loaded. This can be done by
using a Dictionary to store the loaded resources.

- Increase usage of ScriptableObject. GameSettings can be drag into the inspector, and can minimize
code coupling. This can also be used for Item Preset.

- Reusing instantiated objects, or setting up the board pre-game and reusing it.
  
- Increase usage of unified prefabs with good resetting mechanism for Object Pooling.
  
- Item class should only be a data container for currently held Item in a Cell. The Cell should
be the class handling visual of the item.

- Button can either use a drag and drop system for ease of debugging (due to the small amount of button) or an addEventListener system to reduce coupling (if there are a lot of button doing the same thing).