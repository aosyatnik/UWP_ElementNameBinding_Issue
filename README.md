# UWP_ElementNameBinding_Issue
This report demonstrates issue with Binding to ElementName.

# Steps to reproduce:
1. Build and run app. You will see list of 10 numbers and "Redraw" button.
2. Click on "Redraw" button. See, that the whole list is updated at once.
3. Go to `\Themes\Generic.xaml` and fine next code:
```xaml
<TransitionCollection>
   <!-- THIS BINDING IS NOT WORKING -->
   <EntranceThemeTransition IsStaggeringEnabled="{Binding ElementName=Items, Path=DataContext.IsStaggeringEnabled}"
                            FromVerticalOffset="-20"
                            FromHorizontalOffset="-20" />

   <!--<EntranceThemeTransition IsStaggeringEnabled="True"
                                FromVerticalOffset="-20"
                                FromHorizontalOffset="-20" />-->
</TransitionCollection>
```

4. Comment the first `EntranceThemeTransition` and uncomment the second `EntranceThemeTransition`. Code should look like this:
```xaml
<TransitionCollection>
   <!-- THIS BINDING IS NOT WORKING -->
   <!--<EntranceThemeTransition IsStaggeringEnabled="{Binding ElementName=Items, Path=DataContext.IsStaggeringEnabled}"
                                FromVerticalOffset="-20"
                                FromHorizontalOffset="-20" />-->

   <EntranceThemeTransition IsStaggeringEnabled="True"
                            FromVerticalOffset="-20"
                            FromHorizontalOffset="-20" />
</TransitionCollection>
```

5. Click on "Redraw" and see how each item is updated with animation one by one.

# Question:
Why binding is not working?

# Stackoverflow:
https://stackoverflow.com/questions/60207057/uwp-elementname-binding-doesnt-work-in-entrancethemetransition
