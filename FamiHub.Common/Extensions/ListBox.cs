﻿using Gizmox.WebGUI.Forms;

namespace FamiHub.Common.Extensions
{
    public static class ListBoxExtensions
    {
        public static void MoveItem(this ListBox listBox, int direction)
        {
            direction = -direction;
            // Checking selected item
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox.SelectedItem;

            // Removing removable element
            listBox.Items.Remove(selected);
            // Insert it in new position
            listBox.Items.Insert(newIndex, selected);
            // Restore selection
            listBox.SelectedIndex = newIndex;
        }
    }
}
