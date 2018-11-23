﻿using PropertyChanged;
using System.ComponentModel;

namespace PinGo
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

      /// <summary>
      /// Used to fire the event <see cref="PropertyChanged"/> when the property with the <see cref="name"/> changes
      /// </summary>
      /// <param name="name">Name of the property</param>
      public void OnPropertyChanged(string name)
      {
        PropertyChanged(this,new PropertyChangedEventArgs(name));
      }
    }
}
