﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.UI.Popups;

namespace TextPad.Utils
{
    public sealed class DialogBox
    {
        public static async Task<MessageBox.Result> ConfirmSaveChangesDialogAsync()
        {
            var resources = new ResourceLoader();

            var content = resources.GetString("/Resources/MessageDialog_ConfirmSaveChanges_Content");
            var title = resources.GetString("/Resources/MessageDialog_ConfirmSaveChanges_Title");
            var yes = resources.GetString("/Resources/MessageDialog_Yes");
            var no = resources.GetString("/Resources/MessageDialog_No");

            var result = await MessageBox.ShowAsync(
                  content
                , title
                , new UICommand(yes, cmd => { })
                , new UICommand(no, cmd => { })
                );

            return result;
        }
    }
}
