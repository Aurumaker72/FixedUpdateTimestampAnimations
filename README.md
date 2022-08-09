# FixedUpdateTimestampAnimations
the name is a cool acronym btw

## Usage

```cs
OneDimensionalAnimation MyAnimation = new OneDimensionalAnimation(TimeSpan.FromSeconds(1),
    new LinearInterpolator(), // An IInterpolator
    new HoldProgressor(), // An IProgressor
    0, // Start Value 
    100); // End Value
```

## Example

https://user-images.githubusercontent.com/48759429/181923679-6ee551fa-3f7e-495d-88f8-a84482e7dac1.mp4

