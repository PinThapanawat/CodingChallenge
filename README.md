# CodingChallenge

This is a phone pad application that includes two projects. The first one is the main application project, while the second one is a test project. You can use the test project to run tests for the main application code.

# Refactor coding to easy maintain
    From email feedback I got "Logic flow is hard to follow and maintain."

After I got the feedback email. I applies design pattern to code and made those code to clean 

### **Strategy Pattern**:

This pattern could be used to abstract the keypadMapping dictionary and allow for different keypad mappings to be used for conversion. We could define an interface called **IKeypadMapping** with a single method GetMapping which would return the dictionary of key mappings. The OldPhonePadConverter class could then take an instance of an object that implements this interface in its constructor and use it to get the key mappings. This would allow us to easily swap out different key mappings for the converter.

### **Factory Pattern**:

This pattern could be used to encapsulate the creation of different types of converters. We could define an interface called IPhonePadConverter with a single method Convert. We could then create a factory class called PhonePadConverter that takes an input string and returns an instance of the appropriate converter based on the type of input. This would allow us to easily add new converters in the future without modifying the existing code.
