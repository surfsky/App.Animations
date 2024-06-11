# 1.App.Animations


- A simple C# easing animation lib with fluent API.
- Base on net-stardard 2.0 and netframework 4.6.1 without other dependences.
- Support 30+ well-defined easing animations.
- Support custom easing animation.
- Support infinity loop animation.
- Support auto back animation.
- Author: https://www.github.com/surfsky/
- License: MIT


# 2.Install

nuget-insall App.Animations



# 3.Usage


## 3.1 Use extension functions

MoveTo animation:
``` csharp
this.block.MoveTo(new Point(10, 20), new Point(100, 200), 1000);
```

Property animation:
``` csharp
this.picBall.Animate(0, 200, 1000, t => t.Left);
```

Color animation using callback:
``` csharp
var startColor = new List<double> { 255, 0, 0 };
var endColor = new List<double> { 0, 255, 255 };
this.block.Animate(startColor, endColor, 1000, (t, vs) => t.BackColor = ToColor(vs));
Color ToColor(List<double> values) => Color.FromArgb((int)values[0], (int)values[1], (int)values[2]);
```

Custom easing function
```
Func<double, double> func = (v) => Math.Sin(v*Math.PI*2);                                       // define sin easing function
var anim1 = this.picBall.Animate(600, -50, 5000, (t,v) => t.Left = (int)v, EasingType.Linear);  // X use linear animation
var anim2 = this.picBall.Animate(100, 200, 5000, (t,v) => t.Top  = (int)v, easingFunc: func);   // Y use custom animation
```


## 3.2 Use basic fluent api

One value animation example:
```csharp
var ani = new Animator()
    .AddPath(EasingType.ExponentialEaseOut, 100, 300, 1000)
    .AddPath(EasingType.Linear, 300, 100, 500)
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

## 3.3 Other functions

Infinity loop animation:
```
ani.SetInfinity(true);
```

Change interval to make animation more fluent:

```csharp
ani.SetInterval(5);

```

Add autoback paths:
```
ani.AddReversePaths();
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
|:---------------------|:-----------------
| Custom               | Custom easing function: Func<double, double>

