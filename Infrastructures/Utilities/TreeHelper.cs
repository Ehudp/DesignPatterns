using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Infrastructures.Utilities
{
    public static class TreeHelper
    {
        internal static T FindVisualParent<T>(UIElement element) where T : UIElement
        {
            UIElement parent = element;
            while (parent != null)
            {
                var correctlyTyped = parent as T;
                if (correctlyTyped != null)
                {
                    return correctlyTyped;
                }

                parent = VisualTreeHelper.GetParent(parent) as UIElement;
            }
            return null;
        }

        public static T FindVisualParent<T>(DependencyObject child) where T : DependencyObject
        {
            // get parent item
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            // we’ve reached the end of the tree
            if (parentObject == null) return null;

            // check if the parent matches the type we’re looking for
            var parent = parentObject as T;
            if (parent != null)
            {
                return parent;
            }
            // use recursion to proceed with next level
            return FindVisualParent<T>(parentObject);
        }

        private static DependencyObject FindParent(this DependencyObject obj, Predicate<DependencyObject> where)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(obj);

            if (parent == null || @where(parent))
            {
                return parent;
            }

            return parent.FindParent(@where);
        }

        public static T FindParentOfType<T>(this DependencyObject obj) where T : DependencyObject
        {
            return (T) FindParent(obj, x => x is T);
        }

        public static T GetFirstChildByType<T>(DependencyObject prop) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(prop); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild((prop), i);
                if (child == null)
                    continue;

                var castedProp = child as T;
                if (castedProp != null)
                    return castedProp;

                castedProp = GetFirstChildByType<T>(child);

                if (castedProp != null)
                    return castedProp;
            }
            return null;
        }

        public static T FindChild<T>(DependencyObject parent)
            where T : DependencyObject
        {
            // Confirm parent is valid.
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int index = 0; index < childrenCount; index++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, index);
                // If the child is not of the request child type child
                var childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child);

                    // If the child is found, break so we do not overwrite the found child.
                    if (foundChild != null) break;
                }
                else
                {
                    // child element found.
                    foundChild = (T) child;
                    break;
                }
            }
            return foundChild;
        }

        public static T FindChild<T>(DependencyObject parent, string childName)
            where T : DependencyObject
        {
            // Confirm parent is valid.
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int index = 0; index < childrenCount; index++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, index);
                // If the child is not of the request child type child
                var childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child.
                    if (foundChild != null) break;
                }
                else
                {
                    var element = child as FrameworkElement;
                    if (element != null)
                    {
                        if (element.Name == childName || childName == null)
                        {
                            // child element found.
                            foundChild = (T) child;
                            break;
                        }
                    }
                }
            }
            return foundChild;
        }

        public static IEnumerable<T> FindChildren<T>(DependencyObject parent)
            where T : DependencyObject
        {
            // Confirm parent is valid.
            if (parent == null) return null;

            var foundChildren = new List<T>();

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int index = 0; index < childrenCount; index++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, index);
                // If the child is not of the request child type child
                var childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChildren.AddRange(FindChildren<T>(child));
                }
                else
                {
                    // child element found.
                    foundChildren.Add((T) child);
                }
            }
            return foundChildren;
        }


        public static FrameworkElement GetChildByName(this DependencyObject dep, string name)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dep); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(dep, i);
                if (child is FrameworkElement && ((FrameworkElement) child).Name == name)
                    return child as FrameworkElement;
                
                FrameworkElement sub = GetChildByName(child, name);
                if (sub != null)
                    return sub;
            }

            return null;
        }
    }
}