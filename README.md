# How-to-modify-or-disable-shortcuts-of-EditControl
This repository contains the sample that how to modify or disable shortcuts of EditControl.

The EditControl Undo and Redo functionality can be modify or disable by using the IsUndoEnabled and IsRedoEnabled property of Editcontrol.

```C#
public Window1()
{
Edit1.PreviewKeyDown += Edit1_PreviewKeyDown;
}
```

You can also use our PreviewKeyDown event to modify this Undo and Redo features using the following code:

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

