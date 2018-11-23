using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PinGo
{
  /// <summary>
  /// The View model for the custom flat window
  /// </summary>
  public class WindowViewModel : BaseViewModel
  {
    #region Private Member
    private Window mWindow;

    #endregion

    #region Constructor
    public WindowViewModel(Window window)
    {
      mWindow = window;
    }
    #endregion
  }
}
