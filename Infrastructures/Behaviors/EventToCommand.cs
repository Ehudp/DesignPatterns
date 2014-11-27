using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Infrastructures.Behaviors
{

    public sealed class EventToCommand : TriggerAction<DependencyObject>
    {
        private string _commandName;
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(EventToCommand), null);
        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(EventToCommand), null);
        public static readonly DependencyProperty PassEventArgsProperty = DependencyProperty.Register("PassEventArgs", typeof(bool), typeof(EventToCommand), new UIPropertyMetadata(false));
        public static readonly DependencyProperty AcceptEventsFromDescendantsProperty = DependencyProperty.Register("AcceptEventsFromDescendants", typeof(bool), typeof(EventToCommand), new UIPropertyMetadata(false));

        /// <summary>
        /// Gets or sets the name of the command this action should invoke.
        /// </summary>
        /// <value>The name of the command this action should invoke.</value>
        /// <remarks>This property will be superseded by the Command property if both are set.</remarks>
        public string CommandName
        {
            get
            {
                base.ReadPreamble();
                return this._commandName;
            }
            set
            {
                if (this.CommandName != value)
                {
                    base.WritePreamble();
                    this._commandName = value;
                    base.WritePostscript();
                }
            }
        }
        /// <summary>
        /// Gets or sets the command this action should invoke. This is a dependency property.
        /// </summary>
        /// <value>The command to execute.</value>
        /// <remarks>This property will take precedence over the CommandName property if both are set.</remarks>
        public ICommand Command
        {
            get
            {
                return (ICommand)base.GetValue(EventToCommand.CommandProperty);
            }
            set
            {
                base.SetValue(EventToCommand.CommandProperty, value);
            }
        }
        /// <summary>
        /// Gets or sets the command parameter. This is a dependency property.
        /// </summary>
        /// <value>The command parameter.</value>
        /// <remarks>This is the value passed to ICommand.CanExecute and ICommand.Execute.</remarks>
        public object CommandParameter
        {
            get
            {
                return base.GetValue(EventToCommand.CommandParameterProperty);
            }
            set
            {
                base.SetValue(EventToCommand.CommandParameterProperty, value);
            }
        }

        public bool PassEventArgs
        {
            get { return (bool)GetValue(PassEventArgsProperty); }
            set { SetValue(PassEventArgsProperty, value); }
        }

        public bool AcceptEventsFromDescendants
        {
            get { return (bool)GetValue(AcceptEventsFromDescendantsProperty); }
            set { SetValue(AcceptEventsFromDescendantsProperty, value); }
        }



        /// <summary>
        /// Invokes the action.
        /// </summary>
        /// <param name="parameter">The parameter to the action. If the action does not require a parameter, the parameter may be set to a null reference.</param>
        protected override void Invoke(object parameter)
        {

            if (base.AssociatedObject != null)
            {
                var args = parameter as RoutedEventArgs;
                if (args != null)
                {
                    if (!AcceptEventsFromDescendants)
                    {
                        if (!ReferenceEquals(AssociatedObject, args.OriginalSource)) return;
                    }
                }

                ICommand command = this.ResolveCommand();
                if (command != null && command.CanExecute(this.CommandParameter))
                {
                    command.Execute(this.CommandParameter ?? (PassEventArgs ? parameter : null));
                }
            }
        }
        private ICommand ResolveCommand()
        {
            ICommand result = null;
            if (this.Command != null)
            {
                result = this.Command;
            }
            else
            {
                if (base.AssociatedObject != null)
                {
                    Type type = base.AssociatedObject.GetType();
                    PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    PropertyInfo[] array = properties;
                    for (int i = 0; i < array.Length; i++)
                    {
                        PropertyInfo propertyInfo = array[i];
                        if (typeof(ICommand).IsAssignableFrom(propertyInfo.PropertyType) && string.Equals(propertyInfo.Name, this.CommandName, StringComparison.Ordinal))
                        {
                            result = (ICommand)propertyInfo.GetValue(base.AssociatedObject, null);
                        }
                    }
                }
            }
            return result;
        }
    }
}
