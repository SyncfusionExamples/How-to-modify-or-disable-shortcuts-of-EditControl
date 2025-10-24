# How to Modify or Disable Shortcuts of EditControl
This repository provides a detailed example of how to modify or disable keyboard shortcuts in the Syncfusion EditControl for WPF applications. The EditControl is a versatile text editor component that supports syntax highlighting, code editing, and customizable features. In certain scenarios, developers may want to override or disable default shortcuts such as Undo (Ctrl+Z) and Redo (Ctrl+Y) to implement custom logic or restrict user actions.

## Key Features Demonstrated in This Sample

- Disable Undo and Redo functionality using the built-in properties IsUndoEnabled and IsRedoEnabled.
- Intercept keyboard shortcuts using the PreviewKeyDown event.
- Apply conditional logic to enable or disable specific shortcuts dynamically.

## Disable Undo and Redo Using Properties
The simplest way to disable these features is by setting the properties:

```C#
public Window1()
{
Edit1.PreviewKeyDown += Edit1_PreviewKeyDown;
}
```

## Modify Shortcuts Using PreviewKeyDown Event
You can also customize shortcut behavior by handling the PreviewKeyDown event:

```C#
private void Edit1_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
{
if(e.Key == Key.Z && (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0)
{
//Undo feature enable by checking the keys.
Edit1.IsUndoEnabled = true;
}
}
```

This approach gives you full control over how shortcuts behave, allowing you to implement advanced scenarios such as enabling Undo only for certain operations or disabling it entirely in read-only modes.