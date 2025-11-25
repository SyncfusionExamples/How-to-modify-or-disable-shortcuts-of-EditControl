# How to Modify or Disable Shortcuts in WPF EditControl
This example demonstrates how to disable or modify keyboard shortcuts in the Syncfusion WPF EditControl. By default, EditControl supports common shortcuts like Undo (Ctrl+Z) and Redo (Ctrl+Y). In some scenarios, you may want to override or disable these shortcuts to implement custom logic or restrict user actions.

## Why This Is Useful
- **Custom Behavior**: Implement your own shortcut logic.
- **Restrict Actions**: Disable Undo/Redo in read-only or controlled environments.
- **Dynamic Control**: Enable shortcuts only under specific conditions.

## Key Approaches
1. Disable Undo and Redo using properties:
    - IsUndoEnabled = false
    - IsRedoEnabled = false
2. Intercept keyboard shortcuts using PreviewKeyDown:
    - Apply conditional logic to enable or disable shortcuts dynamically.

## Code Example
**XAML**
```XAML
<syncfusion:EditControl Name="Edit1"
                        Grid.Row="2"
                        AllowDrop="True"
                        Background="White"
                        BorderBrush="Black"
                        BorderThickness="0"
                        EnableOutlining="False"
                        FontFamily="Verdana"
                        Height="400"
                        Width="400" />
```

**C#**
```C#

public partial class Window1 : Window
{
    public Window1()
    {
        SfSkinManager.SetTheme(this, new Theme("Office2019Colorful"));
        InitializeComponent();

        Edit1.DocumentSource = @"../../Content.txt";

        // Disable Undo and Redo
        Edit1.IsUndoEnabled = false;
        Edit1.IsRedoEnabled = false;

        // Uncomment to enable dynamic shortcut handling
        // Edit1.PreviewKeyDown += Edit1_PreviewKeyDown;
    }

    private void Edit1_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        // Enable Undo only when Ctrl+Z is pressed
        if (e.Key == Key.Z && (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0)
        {
            Edit1.IsUndoEnabled = true;
        }
    }
}
```

## Notes
- You can extend this logic to handle other shortcuts like Ctrl+Y, Ctrl+C, etc.
- Use PreviewKeyDown for intercepting before default behavior executes.
