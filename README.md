

Hitachi Progress Ring
================

This is a sample application created from the example on [Jerry Nixons blog] (http://blog.jerrynixon.com/2015/06/lets-code-build-custom-progress-ring-in.html) blog on how to create a progress ring. 

    

I created this demo for two reasons, one I wanted to see how to create a custom progress ring. The other reason is on is on 8/27/2015 at the So Cal Azure Users Group in Orange County I saw a presentation on the Hitachi Play book application. A windows 8 application used to keep a register of projects that Hitachi has completed. Since the guys at Hitachi do not get anything back from giving such presentation, I thought it might be nice to see if I could create a custom progress ring control for them. I am not sure if they will use it or not... but as you can see, it is still pretty cool.



![Alt text](https://raw.github.com/StuartSmith/HitachiProgressRing/master/HitachiProgress.gif "Hitachi Progress Ring Example")

 
Sample Code
================
```
<!-- sample XAML for using the Hitachi progress Control -->
<View:HitachiProgress x:Name="PRG1"  Grid.Row="0" Grid.Column="1"   IsActive="True" Foreground="Red"/>
```
