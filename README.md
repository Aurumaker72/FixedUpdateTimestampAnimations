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
