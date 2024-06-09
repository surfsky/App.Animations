# 1.App.Animations


- A simple C# easing animation lib with fluent API.
- Base on net-stardard 2.0 and netframework 4.6.1 whihout other dependences.
- Support 30+ easing animations.
- Support infinity loop animation.
- Author: https://www.github.com/surfsky/
- License: MIT


# 2.Install

nuget-insall App.Animations



# 3.Usage


Simply example:
``` csharp
this.block.Animate(EasingType.Linear, 0, 200, 1000, (t, v) => t.Left = (int)v);
```

One value animation example:
```csharp
var ani = new Animator()
    .AddPath(AnimationType.ExponentialEaseOut, 100, 300, 1000)
    .AddPath(AnimationType.Linear, 300, 100, 500)
    .SetFrameEvent((values) =>
    {
        Action action = () => {label1.Left = (int)values[0];};
        this.Invoke(action);
    })
    .Start()
    ;
```

Two values animation example:

```csharp
var start = new List<double> { 100, 10 };  // x, y
var end   = new List<double> { 300, 100 };
var ani = new Animator()
    .AddPath(AnimationType.ExponentialEaseOut, start, end, 1000)
    .AddPath(AnimationType.Linear, end, start, 500)
    .SetFrameEvent((values) => 
    {
        Action action = () => {
            label1.Left = (int)values[0];
            label1.Top = (int)values[1];
        };
        this.Invoke(action);
    })
    .SetEndEvent((_) => Trace.WriteLine("Animaion end."))
    .Start()
    ;
```


Three values animation example:

```csharp
var start = new List<double> { 255, 0, 0 };        // r, g, b
var end   = new List<double> { 0, 255, 255 };
var ani = new Animator()
    .AddPath(AnimationType.ExponentialEaseOut, start, end, 100)
    .AddPath(AnimationType.Linear, end, start, 500)
    .SetFrameEvent((values) =>
    {
        Action action = () => {
            label1.ForeColor = Color.FromArgb((int)values[0], (int)values[1], (int)values[2]);
        };
        this.Invoke(action);
    })
    .SetEndEvent((_)=> Trace.WriteLine("Animation end."))
    .Start()
    ;
```

Infinity animation:
```
var ani = new Animator(true);
```

Change interval to make animation more fluent:

```csharp
ani.SetInterval(5);

```

Stop animation:

```csharp
ani.Stop();

```

# 4.Supported animation types

| Name                 | Description
|:---------------------|:-----------------
| Linear               | Linear
| BackEaseIn           | Back ease in      
| BackEaseOut          | Back ease out     
| BackEaseInOut        | Back ease in and ease out   
| BounceEaseIn         | Bounce ease in    
| BounceEaseOut        | Bounce ease out   
| BounceEaseInOut      | Bounce ease in and ease out 
| ElasticEaseIn        | Elastic ease in    
| ElasticEaseOut       | Elastic ease out   
| ElasticEaseInOut     | Elastic ease in and ease out
|:---------------------|:-----------------
| QuadraticEaseIn      | Quadratic ease in     
| QuadraticEaseOut     | Quadratic ease out    
| QuadraticEaseInOut   | Quadratic ease in and ease out  
| CubicEaseIn          | Cubic ease in
| CubicEaseInOut       | Cubic ease in and cubic ease out
| CubicEaseOut         | Cubic ease out        
| QuarticEaseIn        | Quartic ease in       
| QuarticEaseOut       | Quartic ease out      
| QuarticEaseInOut     | Quartic ease in and ease outut    
| QuinticEaseIn        | Quintic ease in       
| QuinticEaseOut       | Quintic ease out      
| QuinticEaseInOut     | Quintic ease in and ease out    
| ExponentialEaseIn    | Exponential ease in   
| ExponentialEaseOut   | Exponential ease out  
| ExponentialEaseInOut | Exponential ease in and ease out
|:---------------------|:-----------------
| SinusoidalEaseIn     | Sinusoidal ease in    
| SinusoidalEaseOut    | Sinusoidal ease out   
| SinusoidalEaseInOut  | Sinusoidal ease in and ease out 
| CircularEaseInOut    | Circular ease in and ease out   
| CircularEaseIn       | Circular ease in      
| CircularEaseOut      | Circular ease out     

